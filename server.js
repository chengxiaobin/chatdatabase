var http = require('http');
var fs = require('fs');
var path = require('path');
var mime = require('mime');
var cache = {};

// ��������ļ�������ʱ����404����
function send404(response) {
	console.log('send404 is called.');
	response.writeHead(404, {'Content-Type': 'text/plain'});
	response.write('Error 404: resource not found.');
	response.end();
}

// �ṩ�ļ����ݷ�����д����ȷ��HTTPͷ��Ȼ�����ļ�������
function sendFile(response, filePath, fileContents) {
	console.log('sendFile is called. filePath=' +filePath);
	response.writeHead(
		200,
		{'Content-Type': mime.getType(path.basename(filePath))}
	);
	response.end(fileContents);
}

// �ṩ��̬�ļ�����
function serveStatic(response, cache, absPath) {
	console.log('serveStatic is called. absPath=' +absPath);
  // ����ļ��Ƿ񻺴����ڴ���
	if (cache[absPath]) {
    // ���ڴ��з����ļ�
		sendFile(response, absPath, cache[absPath]);
	} else {
    // ����ļ��Ƿ����
		fs.exists(absPath, function(exists) {
			if (exists) {
        // ��Ӳ���ж�ȡ�ļ�
				fs.readFile(absPath, function(err, data) {
					if (err) {
						send404(response);
					} else {
						cache[absPath] = data;
            // ��Ӳ���ж�ȡ�ļ�������
						sendFile(response, absPath, data);
					}
				});
			} else {
        // �ļ������ڣ�����HTTP 404����
				send404(response);
			}
		});
	}
}

// ����HTTP������
var server = http.createServer(function(request, response) {
	var filePath = false;
	
	if (request.url == '/') {
    // ȷ�����ص�Ĭ��HTML�ļ�
		filePath = 'public/index.html';
	} else {
    // ��URL·��תΪ�ļ������·��
		filePath = 'public' + request.url;
	}
	var absPath = './' + filePath;
  // ���ؾ�̬�ļ�
	serveStatic(response, cache, absPath);
});

// ����HTTP������
server.listen(8000,function() {
	console.log("Server listening on port 8000.");
});

var chatServer = require('./lib/chat_server');
chatServer.listen(server);

