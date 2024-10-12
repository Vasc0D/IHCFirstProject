using UnityEngine;
using System;
using TMPro;

public class L508Horario : MonoBehaviour
{
    [Serializable]
    public class HorarioClase
    {
        public string nombreClase;
        public TimeSpan horaInicio;
        public TimeSpan horaFin;
    }
    public HorarioClase[] lunesClases;
    public HorarioClase[] martesClases;
    public HorarioClase[] miercolesClases;

    public HorarioClase[] juevesClases;

    public HorarioClase[] viernesClases = new HorarioClase[]
    {
        new HorarioClase { nombreClase = "Mecánica de Suelos - Sec.3 (14:00 - 18:00)", horaInicio = new TimeSpan(14, 0, 0), horaFin = new TimeSpan(18, 0, 0) }
    };

    public HorarioClase[] sabadoClases = new HorarioClase[]
    {
        new HorarioClase { nombreClase = "Mecánica de Suelos - Sec.1 (08:00 - 12:00)", horaInicio = new TimeSpan(8, 0, 0), horaFin = new TimeSpan(12, 0, 0) },
        new HorarioClase { nombreClase = "Mecánica de Suelos - Sec.1 (13:00 - 17:00)", horaInicio = new TimeSpan(13, 0, 0), horaFin = new TimeSpan(17, 0, 0) }
    };

    public TextMeshPro texto3D;

    void Start()
    {
        // Al iniciar, muestra la clase correspondiente a la hora actual
        MostrarClaseSegunHora();
    }

    void MostrarClaseSegunHora()
    {

        TimeSpan horaActual = DateTime.Now.TimeOfDay;

        // Obtener el día actual
        int diaActual = (int)DateTime.Now.DayOfWeek;

        // Obtiene el array de clases correspondiente al día de la semana
        HorarioClase[] horarioDelDia = ObtenerHorarioPorDia(diaActual);

        bool claseEncontrada = false; // Para saber si encontramos una clase en el horario

        // Recorre las clases y encuentra la que corresponde a la hora actual
        foreach (HorarioClase clase in horarioDelDia)
        {
            if (horaActual >= clase.horaInicio && horaActual <= clase.horaFin)
            {
                MostrarTexto(clase.nombreClase);
                claseEncontrada = true;
                break;
            }

            if (!claseEncontrada)
            {
                // Si no hay clase en este horario, muestra un mensaje
                MostrarTexto("No hay clase en este horario");
            }
        }
    }

    HorarioClase[] ObtenerHorarioPorDia(int diaActual)
    {
        switch (diaActual)
        {
            case 1: return lunesClases;
            case 2: return martesClases;
            case 3: return miercolesClases;
            case 4: return juevesClases;
            case 5: return viernesClases;
            case 6: return sabadoClases;
            default: return new HorarioClase[0];
        }
    }

    void MostrarTexto(string clase)
    {
        texto3D.text = clase;
    }
}
