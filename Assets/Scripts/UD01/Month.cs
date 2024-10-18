using UnityEngine;

public class Month : MonoBehaviour
{
    public byte Current = 9;


    private void Start() {
        Debug.Log(GetMonthName(Current));
    }


    public string GetMonthName(byte month) {
        switch (month) {
            default: // Si el número es desconocido, devuelve enero.
            case 1:
                return "Enero";
            case 2:
                return "Febrero";
            case 3:
                return "Marzo";
            case 4:
                return "Abril";
            case 5:
                return "Mayo";
            case 6:
                return "Junio";
            case 7:
                return "Julio";
            case 8:
                return "Agosto";
            case 9:
                return "Septiembre";
            case 10:
                return "Octubre";
            case 11:
                return "Noviembre";
            case 12:
                return "Diciembre";
        }
    }
}
