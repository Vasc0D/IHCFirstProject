using UnityEngine;
using System;
using TMPro;

public class L507Horario : MonoBehaviour
{
    [Serializable]
    public class HorarioClase
    {
        public string nombreClase;
        public TimeSpan horaInicio;
        public TimeSpan horaFin;
    }
    public HorarioClase[] lunesClases;
    public HorarioClase[] martesClases = new HorarioClase[]
    {
        new HorarioClase { nombreClase = "Interacción Humano Computador - Sec.1.02 (18:00 - 22:00)", horaInicio = new TimeSpan(18, 0, 0), horaFin = new TimeSpan(22, 0, 0) }
    };
    public HorarioClase[] miércolesClases = new HorarioClase[]
    {
        new HorarioClase { nombreClase = "Computación Gráfica - Sec.1 (09:00 - 11:00)", horaInicio = new TimeSpan(9, 0, 0), horaFin = new TimeSpan(11, 0, 0) },
        new HorarioClase { nombreClase = "Deep Learning - Sec.1 (14:00 - 16:00)", horaInicio = new TimeSpan(14, 0, 0), horaFin = new TimeSpan(16, 0, 0) }
    };

    public HorarioClase[] juevesClases = new HorarioClase[]
    {
        new HorarioClase { nombreClase = "Computación Gráfica - Sec.1 (09:00 - 11:00)", horaInicio = new TimeSpan(9, 0, 0), horaFin = new TimeSpan(11, 0, 0) },
        new HorarioClase { nombreClase = "Interacción Humano Computador - Sec.1.01 (18:00 - 22:00)", horaInicio = new TimeSpan(18, 0, 0), horaFin = new TimeSpan(22, 0, 0) }
    };

    public HorarioClase[] viernesClases = new HorarioClase[]
    {
        new HorarioClase { nombreClase = "Deep Learning - Sec.1.01 (14:00 - 16:00)", horaInicio = new TimeSpan(14, 0, 0), horaFin = new TimeSpan(16, 0, 0) }
    };

    public HorarioClase[] sábadoClases;

    public TextMeshPro texto3D;

    void Start()
    {
        // Al iniciar, muestra la clase correspondiente a la hora actual
        MostrarClaseSegúnHora();
    }

    void MostrarClaseSegúnHora()
    {
        TimeSpan horaActual = DateTime.Now.TimeOfDay;

        // Obtener el día actual
        int díaActual = (int)DateTime.Now.DayOfWeek;

        // Obtiene el array de clases correspondiente al día de la semana
        HorarioClase[] horarioDelDía = ObtenerHorarioPorDía(díaActual);

        bool claseEncontrada = false;

        // Recorre las clases y encuentra la que corresponde a la hora actual
        foreach (HorarioClase clase in horarioDelDía)
        {
            if (horaActual >= clase.horaInicio && horaActual <= clase.horaFin)
            {
                MostrarTexto(clase.nombreClase);
                claseEncontrada = true;
                break;
            }
        }

        if (!claseEncontrada)
        {
            // Si no hay clase en este horario, muestra un mensaje
            MostrarTexto("No hay clase en este horario");
        }
    }

    HorarioClase[] ObtenerHorarioPorDía(int díaActual)
    {
        switch (díaActual)
        {
            case 1: return lunesClases;
            case 2: return martesClases;
            case 3: return miércolesClases;
            case 4: return juevesClases;
            case 5: return viernesClases;
            case 6: return sábadoClases;
            default: return new HorarioClase[0];
        }
    }

    void MostrarTexto(string clase)
    {
        texto3D.text = clase;
    }
}