using UnityEngine;
using System;
using TMPro;

public class MostrarClasePorHorario : MonoBehaviour
{
    [Serializable]
    public class HorarioClase
    {
        public string nombreClase;
        public TimeSpan horaInicio;
        public TimeSpan horaFin;
    }

    public HorarioClase[] lunesClases = new HorarioClase[]
    {
        new HorarioClase { nombreClase = "Hidráulica Superficial-Sec.2 (08:00 - 10:00)", horaInicio = new TimeSpan(8, 0, 0), horaFin = new TimeSpan(10, 0, 0) },
        new HorarioClase { nombreClase = "Mantenimiento (10:00 - 12:00)", horaInicio = new TimeSpan(10, 0, 0), horaFin = new TimeSpan(12, 0, 0) },
        new HorarioClase { nombreClase = "Estadística y Probabilidades I - Sec.9 (15:00 - 17:00)", horaInicio = new TimeSpan(15, 0, 0), horaFin = new TimeSpan(17, 0, 0) },
        new HorarioClase { nombreClase = "Estadística y Probabilidades I - Sec.5 (17:00 - 19:00)", horaInicio = new TimeSpan(17, 0, 0), horaFin = new TimeSpan(19, 0, 0) },
        new HorarioClase { nombreClase = "PRE UTEC (19:00 - 21:00)", horaInicio = new TimeSpan(19, 0, 0), horaFin = new TimeSpan(21, 0, 0) }
    };
    public HorarioClase[] martesClases;
    public HorarioClase[] miércolesClases = new HorarioClase[]
    {
        new HorarioClase { nombreClase = "Programación I - Sec.1 (09:00 - 11:00)", horaInicio = new TimeSpan(9, 0, 0), horaFin = new TimeSpan(11, 0, 0) },
        new HorarioClase { nombreClase = "Desarrollo de Productos de Datos - Sec.1 (11:00 - 13:00)", horaInicio = new TimeSpan(11, 0, 0), horaFin = new TimeSpan(13, 0, 0) },
        new HorarioClase { nombreClase = "Estadística y Probabilidades I - Sec.9 (13:00 - 14:00)", horaInicio = new TimeSpan(13, 0, 0), horaFin = new TimeSpan(14, 0, 0) },
        new HorarioClase { nombreClase = "Teoría de la Computación - Sec.2 (14:00 - 16:00)", horaInicio = new TimeSpan(14, 0, 0), horaFin = new TimeSpan(16, 0, 0) },
        new HorarioClase { nombreClase = "Base de Datos I - Sec.3 (16:00 - 18:00)", horaInicio = new TimeSpan(16, 0, 0), horaFin = new TimeSpan(18, 0, 0) },
        new HorarioClase { nombreClase = "Programación II - Sec.1 (18:00 - 20:00)", horaInicio = new TimeSpan(18, 0, 0), horaFin = new TimeSpan(20, 0, 0) },
        new HorarioClase { nombreClase = "Programación II - Sec.1 (20:00 - 22:00)", horaInicio = new TimeSpan(20, 0, 0), horaFin = new TimeSpan(22, 0, 0) }
    };

    public HorarioClase[] juevesClases = new HorarioClase[]
    {
        new HorarioClase { nombreClase = "Ingeniería de mantenimiento - Sec.1 (08:00 - 10:00)", horaInicio = new TimeSpan(8, 0, 0), horaFin = new TimeSpan(10, 0, 0) },
        new HorarioClase { nombreClase = "Programación I - Sec.1 (11:00 - 13:00)", horaInicio = new TimeSpan(11, 0, 0), horaFin = new TimeSpan(13, 0, 0) },
        new HorarioClase { nombreClase = "Reserva de Ambientes (13:00 - 15:00)", horaInicio = new TimeSpan(13, 0, 0), horaFin = new TimeSpan(15, 0, 0) },
        new HorarioClase { nombreClase = "Análisis Matricial de Estructuras - Sec.1 (16:00 - 18:00)", horaInicio = new TimeSpan(16, 0, 0), horaFin = new TimeSpan(18, 0, 0) },
        new HorarioClase { nombreClase = "Programación II - Sec.2 (18:00 - 20:00)", horaInicio = new TimeSpan(18, 0, 0), horaFin = new TimeSpan(20, 0, 0) },
        new HorarioClase { nombreClase = "Ingeniería de Software - Sec.1 (20:00 - 22:00)", horaInicio = new TimeSpan(20, 0, 0), horaFin = new TimeSpan(22, 0, 0) }
    };

    public HorarioClase[] viernesClases = new HorarioClase[]
    {
        new HorarioClase { nombreClase = "Cloud Computing-Sec.1 (07:00 - 09:00)", horaInicio = new TimeSpan(7, 0, 0), horaFin = new TimeSpan(9, 0, 0) },
        new HorarioClase { nombreClase = "Teoría de la Computación-Sec.1 (09:00 - 11:00)", horaInicio = new TimeSpan(9, 0, 0), horaFin = new TimeSpan(11, 0, 0) },
        new HorarioClase { nombreClase = "Programación II-Sec.2 (11:00 - 13:00)", horaInicio = new TimeSpan(11, 0, 0), horaFin = new TimeSpan(13, 0, 0) },
        new HorarioClase { nombreClase = "Programación II-Sec.2 (13:00 - 15:00)", horaInicio = new TimeSpan(13, 0, 0), horaFin = new TimeSpan(15, 0, 0) },
        new HorarioClase { nombreClase = "Álgebra Lineal-Sec.1 (15:00 - 17:00)", horaInicio = new TimeSpan(15, 0, 0), horaFin = new TimeSpan(17, 0, 0) },
        new HorarioClase { nombreClase = "Dibujo y diseño para Ingeniería-Sec.2 (18:00 - 20:00)", horaInicio = new TimeSpan(18, 0, 0), horaFin = new TimeSpan(20, 0, 0) },
        new HorarioClase { nombreClase = "Ingeniería de Carreteras-Sec.1 (20:00 - 22:00)", horaInicio = new TimeSpan(20, 0, 0), horaFin = new TimeSpan(22, 0, 0) }
    };

    public HorarioClase[] sábadoClases = new HorarioClase[]
    {
        new HorarioClase { nombreClase = "Cloud Computing-Sec.1 (07:00 - 09:00)", horaInicio = new TimeSpan(7, 0, 0), horaFin = new TimeSpan(9, 0, 0) },
        new HorarioClase { nombreClase = "Maestría de Cd del A v1 (09:00 - 14:00)", horaInicio = new TimeSpan(9, 0, 0), horaFin = new TimeSpan(14, 0, 0) },
        new HorarioClase { nombreClase = "Métodos Numéricos-Sec.1 (14:00 - 16:00)", horaInicio = new TimeSpan(14, 0, 0), horaFin = new TimeSpan(16, 0, 0) },
        new HorarioClase { nombreClase = "Maestría de Cd del A v1 (16:00 - 19:00)", horaInicio = new TimeSpan(16, 0, 0), horaFin = new TimeSpan(19, 0, 0) }
    };

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

        bool claseEncontrada = false; // Para saber si encontramos una clase en el horario

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