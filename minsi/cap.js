// 현재 차단기 상태를 추적하는 변수
let isBarrierUp = false;

// 라인 차트 초기화
let lineChart;

function initializeLineChart() 
{
    const ctxLine = document.getElementById('myLineChart').getContext('2d');
    lineChart = new Chart(ctxLine, {
        type: 'line',
        data: {
            labels: [], // 시간 라벨
            datasets: [{
                label: 'Water Level',
                data: [], // 수위 데이터 (0~100%)
                fill: false,
                borderColor: 'rgb(75, 192, 192)',
                tension: 0.1
            }]
        },
        options: {
            scales: {
                x: {
                    title: {
                        display: true,
                        text: 'Time'
                    }
                },
                y: {
                    beginAtZero: true,
                    max: 100, // Y축 최대값 (100%)
                    ticks: {
                        callback: function (value) 
                        {
                            const labels = { 20: 'A', 40: 'B', 60: 'C', 80: 'D', 100: 'E', 0: 'X' };
                            return labels[value] || '';
                        }
                    },
                    title: {
                        display: true,
                        text: 'Water Level'
                    }
                }
            }
        }
    });
}

// 아두이노 데이터 기반으로 물탱크, 차트, 차단기 업데이트
function fetchData() 
{
    fetch('http://localhost:3000/') // Node.js 서버에서 아두이노 데이터를 가져옴
        .then(response => response.text())
        .then(data => {
            console.log("수신된 데이터:", data);
            updateWaterTank(data);
            updateLineChart(data);
            controlBarrier(data); 
            updateArduinoData(data); // 데이터를 출력하는 함수 추가
        })
        .catch(error => console.error("데이터 가져오기 오류:", error));
}

function updateArduinoData(data) 
{
    const arduinoDataContainer = document.getElementById('arduinoDataContainer');
    arduinoDataContainer.textContent = `현재 수신된 데이터: ${data}`;
    console.log(`아두이노 데이터 출력: ${data}`);
}

function updateWaterTank(data) 
{
    const waterLevel = document.getElementById('waterLevel');
    let currentHeight = 0;

    if (data === 'A') 
    {
        currentHeight = 20;
    } 
    else if (data === 'B') 
    {
        currentHeight = 40;
    } 
    else if (data === 'C') 
    {
        currentHeight = 60;
    } 
    else if (data === 'D') 
    {
        currentHeight = 80;
    } 
    else if (data === 'E') 
    {
        currentHeight = 100;
    } 
    else if (data === 'X') 
    {
        currentHeight = 0; // "X"를 수신하면 수위를 0으로 설정
    }

    waterLevel.style.height = currentHeight + "%";
    console.log(`물탱크 수위가 ${currentHeight}%로 업데이트되었습니다.`);
}

function updateLineChart(data) 
{
    const now = new Date();
    const timeLabel = `${now.getHours()}:${now.getMinutes()}:${now.getSeconds()}`;
    let currentHeight = 0;

    if (data === 'A') 
    {
        currentHeight = 20;
    } 
    else if (data === 'B') 
    {
        currentHeight = 40;
    } 
    else if (data === 'C') 
    {
        currentHeight = 60;
    } 
    else if (data === 'D') 
    {
        currentHeight = 80;
    } 
    else if (data === 'E') 
    {
        currentHeight = 100;
    } 
    else if (data === 'X') 
    {
        currentHeight = 0; // "X"를 수신하면 차트 데이터를 0으로 설정
    }

    lineChart.data.labels.push(timeLabel);
    lineChart.data.datasets[0].data.push(currentHeight);

    lineChart.update();
}

function controlBarrier(data) 
{
    const barrierArm = document.getElementById('barrierArm');

    if ((data === 'A' || data === 'X') && !isBarrierUp) 
    {
        // "A" 또는 "X"를 수신하면 차단기 올라감
        barrierArm.style.transform = 'rotate(-90deg)';
        isBarrierUp = true;
        console.log("차단기가 올라갔습니다.");
    }

    if (['B', 'C', 'D', 'E'].includes(data) && isBarrierUp) 
    {
        // "B", "C", "D", "E"를 수신하면 차단기 내려감
        barrierArm.style.transform = 'rotate(0deg)';
        isBarrierUp = false;
        console.log("차단기가 내려갔습니다.");
    }
}

// 1.8초마다 데이터 가져오기
setInterval(fetchData, 1800);

// 페이지 로드 시 차트 초기화
window.onload = initializeLineChart;
