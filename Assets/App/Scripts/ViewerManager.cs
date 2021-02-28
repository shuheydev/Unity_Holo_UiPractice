using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewerManager : MonoBehaviour
{
    public bool IsVisible;
    private bool _isVisible;

    // Start is called before the first frame update
    void Start()
    {
        InitOnLoad();
    }

    // Update is called once per frame
    void Update()
    {

    }

    [RuntimeInitializeOnLoadMethod]
    void InitOnLoad()
    {
        _isVisible = IsVisible;
        gameObject.SetActive(_isVisible);
    }

    public void ToggleVisibility()
    {
        _isVisible = !_isVisible;
        gameObject.SetActive(_isVisible);
    }
}
