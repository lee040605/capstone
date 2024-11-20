// serialport 모듈 가져오기
const { SerialPort } = require('serialport');
const { ReadlineParser } = require('@serialport/parser-readline');
const http = require('http');

// 시리얼 포트 경로와 속도 설정
const port = new SerialPort({ path: 'COM3', baudRate: 115200 });
const parser = port.pipe(new ReadlineParser({ delimiter: '\r\n' }));

// 최신 데이터 저장
let latestData = "데이터 없음";

// 시리얼 포트에서 데이터 수신
parser.on('data', (data) => 
{
    latestData = data.trim();
    console.log(`아두이노로부터 수신된 데이터: ${latestData}`);
});

// HTTP 서버 설정
const server = http.createServer((req, res) => 
{
    res.writeHead(200, 
	{
        'Content-Type': 'text/plain',
        'Access-Control-Allow-Origin': '*' // CORS 헤더 추가
    });
    res.end(latestData);
});

server.listen(3000, () => 
{
    console.log("HTTP 서버가 포트 3000에서 실행 중입니다.");
});

console.log("시리얼 포트에서 데이터 수신을 기다리는 중...");
