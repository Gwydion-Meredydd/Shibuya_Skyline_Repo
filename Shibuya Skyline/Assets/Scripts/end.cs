using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    bool active = true;
    public GameObject row1, row2, row3, row4, row5, row6, row7, row8, row9, row10, row11, row12, row13, row14, row15, row16, row17, row18, 
                      row19, row20, row21, row22, row23, row24, row25, row26, row27, row28, row29, row30, row31, row32, row33, row34, row35,
                      row36, row37, row38, row39, row40, row41, row42, row43, row44, row45, row46, row47, row48, row49, row50, row51, row52,
                      row53, row54, row55, row56, row57, row58, row59, row60, row61, row62, row63, row64, row65, row66, row67, row68, row69,
                      row70, row71, row72, row73, row74, row75, row76, row77, row78, row79;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "player" && active == true)
        {
            StartCoroutine(RoadContinue());
        }
        //SceneManager.LoadScene("Menu");
    }

    IEnumerator RoadContinue()
    {
        yield return new WaitForSeconds(0.5f);
        row1.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row2.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row3.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row4.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row5.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row6.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row7.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row8.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row9.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row10.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row11.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row12.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row13.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row14.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row15.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row16.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row17.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row18.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row19.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row20.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row21.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row22.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row23.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row24.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row25.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row26.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row27.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row28.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row29.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row30.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row31.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row32.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row33.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row34.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row35.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row36.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row37.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row38.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row39.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row40.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row41.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row42.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row43.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row44.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row45.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row46.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row47.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row48.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row49.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row50.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row51.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row52.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row53.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row54.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row55.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row56.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row57.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row58.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row59.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row60.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row61.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row62.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row63.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row64.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row65.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row66.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row67.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row68.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row69.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row70.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row71.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row72.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row73.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row74.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row75.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row76.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row77.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row78.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        row79.SetActive(true);
        active = false;
    }
}