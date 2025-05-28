#include <Servo.h>

int waterPins[] = {A0, A1, A2, A3, A4};  // 5개의 물 센서 핀
int numSensors = 5;  // 센서 개수

char msg[] = {'A', 'B', 'C', 'D', 'E'};  // 각 수위에 해당하는 문자
Servo barrierServo;  // 서보 모터 객체 생성
int servoPin = 9;    // 서보 모터가 연결된 핀 번호

void setup() 
{
  Serial.begin(115200);  // 시리얼 통신 속도 설정

  for (int i = 0; i < numSensors; i++) 
  {
    pinMode(waterPins[i], INPUT);  // 센서 핀을 입력 모드로 설정
  }

  barrierServo.attach(servoPin);  // 서보 모터를 지정된 핀에 연결
  barrierServo.write(0);  // 초기 상태에서 차단막을 올림
}

void loop() 
{
  char highestSensor = 'X';  // 기본값을 'X'로 설정

  // 각 센서의 값을 읽고 가장 높은 수위를 감지
  for (int i = 0; i < numSensors; i++) 
  {
    int value = analogRead(waterPins[i]);
    if (value > 700)  // 감지 임계값을 초과한 경우
    {
      highestSensor = msg[i];  // 가장 높은 수위를 나타내는 문자로 업데이트
    }
  }

  // 서보 모터 제어
  if (highestSensor == 'A' || highestSensor == 'X') 
  {
    barrierServo.write(0);  // 차단막을 올림
  } 
  else if (highestSensor == 'B' || highestSensor == 'C' || highestSensor == 'D' || highestSensor == 'E') 
  {
    barrierServo.write(90);  // 차단막을 내림
  }

  Serial.println(highestSensor);  // 현재 감지된 수위 문자를 시리얼로 출력
  delay(1000);  // 1초 대기 후 반복
}
