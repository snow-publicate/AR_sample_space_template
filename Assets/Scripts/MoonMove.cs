using UnityEngine;

public class MoonMove : MonoBehaviour
{
    //public으로 선언하여, 유니티 에디터에서 수정을 가능케 함과 동시에 
    //다른 스크립트에서도 time변수에 접근할 수 있게 합니다.
    public GameObject target; //태양을 유니티 에디터에서 타겟으로 삼기 위한 변수 선언
    private Vector3 targetPosition; //태양의 위치를 담기 위한 변수 선언
    public GameObject earth; //지구를 유니티 에디터에서 담기 위한 변수 선언
    private float earthSpeed; //지구의 속도를 담기 위한 변수 선언

    private void Start() 
    {
        // targetPosition = target.GetComponent<Transform>().position; //태양의 위치를 변수에 할당
        targetPosition = GameObject.Find("Sun").GetComponent<Transform>().position; //태양의 위치를 변수에 할당

        earth = GameObject.Find("Earth"); //지구를 찾아 변수에 할당
    }

    private void Update() 
    {
        //지구의 속도를 변수에 할당 및 달에 맞게 변환
        earthSpeed = earth.GetComponent<EarthMove>().speed; 

        //본 스크립트가 부착된 객체를 반시계방향으로 자전 (달의 공전에 대응)
        transform.Rotate(Vector3.down * Time.deltaTime * earthSpeed * 365f / 27f);

        //본 스크립트가 부착된 객체를 반시계방향으로 대상 중심으로 공전 
        transform.RotateAround(targetPosition, Vector3.down, Time.deltaTime * earthSpeed);
    }
}

