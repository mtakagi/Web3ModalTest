using System;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

namespace Web3ModalTest {
public class Test : MonoBehaviour
{
    [SerializeField] private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button.OnClickAsObservable().Subscribe(_ => {
            Debug.Log("OnCLick!");
        }).AddTo(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

}
