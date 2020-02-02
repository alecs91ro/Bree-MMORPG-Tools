// =======================================================================================
// Maintained by bobatea#9400 on Discord
// Usable for both personal and commercial projects, but no sharing or re-sale
// * Discord Support Server.............:  
  
// * Leave a star on my Github Repo.....: https://github.com/breehuynh/Bree-mmorpg-tools
// * Instructions.......................: https://indie-mmo.net/knowledge-base/
// =======================================================================================
using UnityEngine;
using UnityEngine.UI;

// SHORTCUTS

public partial class UCE_UI_HarvestingProfessions_Shortcuts : MonoBehaviour
{
    public Button HarvestingProfessionsButton;
    public GameObject HarvestingProfessionsPanel;

    // -----------------------------------------------------------------------------------
    // Update
    // -----------------------------------------------------------------------------------
    public void Update()
    {
        HarvestingProfessionsButton.onClick.SetListener(() =>
        {
            HarvestingProfessionsPanel.SetActive(!HarvestingProfessionsPanel.activeSelf);
        });
    }

    // -----------------------------------------------------------------------------------
}
