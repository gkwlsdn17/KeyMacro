# KeyMacro

키매크로<br/>

제작일시: 2023-03-03
제작인원: 1명
사용언어: C#<br/>
프레임워크: .NET 6.0 <br/>
====================================================================<br/>
사용 방법<br/>
KeyMacro.exe 파일 실행<br/>
<br/>
키 부분 텍스트박스에 사용할 키를 입력 ex) A<br/>
딜레이 부분에 키 하나당 딜레이 줄 값을 입력 ex) 300<br/>
반복주기에는 몇초마다 반복을 할건지 값 입력, 반복주기없이 그냥 계속 수행할거면 0 입력<br/>
추가를 눌러 왼쪽 리스트에 추가가 정상적으로 되었는지 확인<br/>
<br/>
왼쪽에 올라간 리스트 항목 선택해서 텍스트박스 수정해서 수정 버튼 누르면 수정 가능<br/>
왼쪽에 올라간 리스트 항목 선택해서 삭제버튼 누르면 삭제 가능<br/>
<br/>
리스트를 세팅하고 저장버튼 눌러서 저장 가능<br/>
불러오기 눌러서 저장한 텍스트파일 누르면 기존에 설정했던 값 가져오기 가능<br/>
<br/>
시작버튼을 누르면 세팅한값대로 매크로 시작<br/>
중단을 누르면 매크로 종료<br/>
만약 딜레이를 너무 짧게주면(ex. 10ms) 중단버튼이 안눌릴수있음<br/>
그러면 연속으로 눌러보거나 아예 창을 닫아서 끄기<br/>
딜레이는 100ms 이상으로 권장<br/>
<br/>
특수키 (ex. F1, ENTER, ,,, etc)는 도움말 버튼 눌러 참고<br/>
도움말 특수키 리스트중 사용하고싶은거 눌러서 ctrl + c 누르면 사용하는 Code 복사 가능<br/>
<br/>
조합도 도움말 버튼 눌러서 참고<br/>
<br/>
코드 사용이 어렵거나 더 자세히 알고싶다면 구글에 "SendKeys 코드"라고 검색해서 확인<br/>
====================================================================<br/>
정상적으로 실행이 안될시 마우스우클릭 -> 관리자권한으로실행 <br/>
