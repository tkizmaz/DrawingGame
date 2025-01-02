using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Barracuda;

public class ModelController : MonoBehaviour
{
    [SerializeField]
    private NNModel modelSource;
    private IWorker worker;
    // Start is called before the first frame update
    void Start()
    {
        var model = ModelLoader.Load(modelSource);
        worker = WorkerFactory.CreateWorker(WorkerFactory.Type.Auto, model);
    }
}
