using UnityEngine;
using UnityEngine.UI; //UI관련 기능 접근을 위한 네임스페이스 선언

public class SpeedControlSlider2 : MonoBehaviour
{
    public Slider slider; //slider변수를 public으로 선언하여 유니티 에디터에서의 접근 허용
    public GameObject earth; //지구를 유니티 에디터에서 담기 위한 변수 선언

    public void Start()
    {
        //slider의 onValuChanged 속성에 ValueChangeCheck()라는 하단의 함수를 delegate 명령을 통해 할당하여 리스너 추가
        slider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
    }

    //slider의 값이 바뀌면 호출할 함수 선언
    public void ValueChangeCheck()
    {
        //유니티 에디터 상의 Earth객체를 찾고, 그 속의 EarthMove스크립트 컴포넌트 speed값에 접근하여 슬라이드 밸류값으로 변환
        earth.GetComponent<Speed>().speed = slider.value;
    }
}

