using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TMPLocalizer : MonoBehaviour
{
    public TMP_Text TMP_Text;
    public string key;

    // Start is called before the first frame update
    void Start()
    {
        UpdateText();
    }

    public void UpdateText()
    {
        if (TMP_Text == null) return;
        TMP_Text.text = LocalizationSystem.instance.GetText(key);
    }
    private void OnDrawGizmos()
    {
        if (TMP_Text == null)
            TMP_Text = GetComponent<TMP_Text>();
    }
}
