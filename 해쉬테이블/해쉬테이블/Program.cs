namespace 해쉬테이블
{
    public struct StudentData
    {
        public string name;
        public string address;
        public int score;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //학생 : 학생정보(value : 값)
            //핸드폰 번호 : 찾기 위한 수단(key : 키)
            StudentData[] data = new StudentData[10000];

            // 해시(Hash) : 핸드폰 뒷자리 4자리를 써서 사용하자

            data[1234] = new StudentData { name = "홍길동", address = "서울", score = 100 };
            data[1111] = new StudentData { name = "김전사", address = "서울", score = 100 };

            StudentData hong = data[1234];
            StudentData kim = data[1111];
        }
    }
}
