using UnityEngine;

public class Shop : MonoBehaviour
{

    public TurretBlueprint standardTurret;
    public TurretBlueprint missleLauncher;
    public TurretBlueprint laserBeamer;

    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.insatance;
    }

    public void SelectStandardTurret()
    {
        Debug.Log("Standard turret selected");
        buildManager.SelectTurretToBuild(standardTurret);
    }

    public void SelectMissleLauncher()
    {
        Debug.Log("Missle launcher selected");
        buildManager.SelectTurretToBuild(missleLauncher);
    }

    public void SelectLaserBeamer()
    {
        Debug.Log("Laser Beamer selected");
        buildManager.SelectTurretToBuild(laserBeamer);
    }

}
