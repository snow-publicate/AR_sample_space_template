using UnityEngine;

public class PlanetRotate : MonoBehaviour
{
    private GameObject earth;
    private float earthSpeed;

    //유니티 에디터로 접근하여 행성별 속도 배수값을 입력하기 위한 변수 선언
    public float planetSpeed;

    private void Start() {
        earth = GameObject.Find("Earth");
    }

    private void Update() 
    {
        //slider로 변하는 지구의 각속도 지속적으로 탐색
        earthSpeed = earth.GetComponent<Speed>().speed; 

        //본 스크립트가 부착된 객체를 반시계방향으로 자전(지구의 각속도에 행성의 배수값을 곱)
        transform.Rotate(Vector3.down * Time.deltaTime * earthSpeed * planetSpeed);
    }
}

