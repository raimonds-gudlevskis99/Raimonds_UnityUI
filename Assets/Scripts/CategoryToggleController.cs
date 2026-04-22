using UnityEngine;

public class CategoryToggleController : MonoBehaviour
{
    public GameObject hatsDropdown;
    public GameObject shirtsDropdown;
    public GameObject pantsDropdown;
    public GameObject shoesDropdown;

    public void ToggleHats(bool isOn)
    {
        hatsDropdown.SetActive(isOn);
    }

    public void ToggleShirts(bool isOn)
    {
        shirtsDropdown.SetActive(isOn);
    }

    public void TogglePants(bool isOn)
    {
        pantsDropdown.SetActive(isOn);
    }

    public void ToggleShoes(bool isOn)
    {
        shoesDropdown.SetActive(isOn);
    }
}