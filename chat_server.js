var socketio = require('socket.io');
var io;
var guestNumber = 1;
var nickNames = {};
var currentRoom = {};
var namesUsed = [];
var roomsUsed = [];
var mysql = require('mysql');
var TEST_DATABASE = 'test';
var TEST_TABLE = 'chatdata';
var cp  = require('child_process')
const path = require('path');
const fs = require('fs');


var initApp = function() {
 var vbsPath = path.join('C:\\Users\\cxbbe\\Desktop\\test\\chatrooms-master\\', 'vbmessage.vbs')

 cp.exec('cscript.exe ' + vbsPath + ' "warnning" "Civilized Internet access, please!!!"', function(err, stdout, stderr) {
  if (err) {
   fs.writeFileSync('log.log', err.toString())
  }
 })
}

var client = mysql.createConnection({

	user: 'root',

	password: '666',

	});

	client.connect();
	client.query("use " + TEST_DATABASE);

// ����Socket.IO������
exports.listen = function(server) {
  // ����Socket.IO�����������������������е�HTTP��������
  io = socketio.listen(server);
  
  // ����ÿ���û����ӵĴ����߼�
  io.sockets.on('connection', function(socket) {
    // ���û���������ʱ������һ���ÿ���
    guestNumber = assignGuestName(socket);
    // ���û���������ʱ��������������defaultRoom��
    joinRoom(socket, 'myRoom1');
    // �����û�����Ϣ���������Լ������ҵĴ����ͱ��
    handleMessageBroadcasting(socket);
    handleNameChangeAttempts(socket);
    handleRoomJoining(socket);
   
    console.log("char_server: rooms.length=" +roomsUsed.length +", rooms=" +roomsUsed);
    
    // �û���������ʱ�������ṩ�Ѿ���ռ�õ��������б�
    socket.on('rooms', function() {
      socket.emit('rooms', roomsUsed);
    });
    
    // �����û��Ͽ����Ӻ������߼�
    handleClientDisconnection(socket);
  });
};

// �����û��ǳ�
function assignGuestName(socket) {
  // �������ǳ�
  var name = 'Guest' + guestNumber;
  nickNames[socket.id] = name;
  // ���û�֪�����ǵ��ǳ�
  socket.emit('nameResult', {
    success: true,
    name: name
  });
  // ����Ѿ���ռ�õ��ǳ�
  namesUsed.push(name);
  console.log("assignGuestName is called. name=" +name +", id=" +socket.id +", namesUsed=" +namesUsed);
  // �������������ǳƵļ�����
  return guestNumber+1;
}

// ����������
function joinRoom(socket, room) {
  // ���û����뷿��
  socket.join(room);
  if (roomsUsed.indexOf(room) == -1) {
    roomsUsed.push(room);
  }
  
  // ��¼�û��ĵ�ǰ����
  currentRoom[socket.id] = room;
  // ���û�֪�����ǽ������µķ���
  socket.emit('joinResult', {room: room});
  // �÷�����������û�֪�������û������˷���
  socket.broadcast.to(room).emit('message', {
    text: nickNames[socket.id] + ' has joined ' + room + '.'
  });
  
  // ���Ҳ���¼����Щ�û������������
  var usersInRoomSummary = 'Users currently in ' + room + ': ';
  var userArray = [];
  for (var croom in currentRoom) {
    if (room === currentRoom[croom]) {
      for (var index in nickNames) {
        if (croom === index) {
          userArray.push(nickNames[index]);
          console.log("joinRoom: find a user in the room. id=" +croom +", room=" +currentRoom[croom] +", user=" +nickNames[index]);
        }
      }
    }
  }
  usersInRoomSummary += userArray.join(",") + '.';
  // �������������û��Ļ��ܷ��͸�����û�
  socket.emit('message', {text: usersInRoomSummary});
}

// ��������Ĵ����߼�
function handleNameChangeAttempts(socket) {
  // ���nameAttempt�¼��ļ�����
  socket.on('nameAttempt', function(name) {
    // �ǳƲ�����Guest��ͷ
    if (name.indexOf('Guest') == 0) {
      socket.emit('nameResult', {
        success: false,
        message: 'Names cannot begin with "Guest".'
      });
    } else {
      // ������ǳ�δ��ע�ᣬ��ע��
      if (namesUsed.indexOf(name) == -1) {
        var previousName = nickNames[socket.id];
        var previousNameIndex = namesUsed.indexOf(previousName);
        namesUsed.push(name);
        nickNames[socket.id] = name;
        // ɾ��֮ǰ�õ��ǳƣ��������û�����ʹ��
        delete namesUsed[previousNameIndex];
        socket.emit('nameResult', {
          success: true,
          name: name
        });
        socket.broadcast.to(currentRoom[socket.id]).emit('message', {
          text: previousName + ' is now known as ' + name + '.'
        });
      } else {
        // ����ǳ��Ѿ���ռ�ã����ͻ��˷��ʹ�����Ϣ
        socket.emit('nameResult', {
          success: false,
          message: 'That name is already in use.'
        });
      }
    }
  });
}

// ����������Ϣ
function handleMessageBroadcasting(socket) {
  socket.on('message', function(message) {
    socket.broadcast.to(message.room).emit('message', {
      text: nickNames[socket.id] + ': ' + message.text
    });
	var  restext=message.text;
	var  userGetSql = 'SELECT * FROM fobiddata';
	client.query(userGetSql,function (err, result) {

        if(err){
          throw err; 
        }       
       if(result)

      {
		 
		  for(var i = 0; i < result.length; i++)

          {
			
            if(result[i].data==message.text){initApp()}

          }
      }  
		});
	var  userAddSql = 'INSERT INTO chatdata(username,data) VALUES(?,?)';

	var  userAddSql_Params = [nickNames[socket.id], message.text];

//�� add
	client.query(userAddSql,userAddSql_Params,function (err, result) {

        if(err){

         console.log('[INSERT ERROR] - ',err.message);

         return;

        }       

       console.log('-------INSERT----------');

       //console.log('INSERT ID:',result.insertId);       

       console.log('INSERT ID:',result);       

       console.log('#######################'); 

});
	client.query( 'SELECT id,username FROM chatdata where EXISTS(select * from fobiddata where fobiddata.data=chatdata.data)', 

  function selectCb(err, results, fields) { 

    if (err) { 

      throw err; 

    } 

       if(results)

      {
		 
		  for(var i = 0; i < results.length; i++)

          {
			
            console.log("%d\t%s", results[i].id, results[i].username);

          }
      }   


  } 

);
  });
}

// ��������
function handleRoomJoining(socket) {
  socket.on('join', function(room) {
    socket.leave(currentRoom[socket.id]);
    joinRoom(socket, room.newRoom);
  });
}

// �û��Ͽ�����
function handleClientDisconnection(socket) {
  socket.on('disconnect', function() {
    var nameIndex = namesUsed.indexOf(nickNames[socket.id]);
    delete namesUsed[nameIndex];
    delete nickNames[socket.id];
  });
}






