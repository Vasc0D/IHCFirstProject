using UnityEngine;
using System;
using TMPro;

public class A904Horario : MonoBehaviour
{
    [Serializable]
    public class HorarioClase
    {
        public string nombreClase;
        public TimeSpan horaInicio;
        public TimeSpan horaFin;
    }

    // Aquí defines los horarios de las clases por días
    public HorarioClase[] lunesClases = new HorarioClase[]
    {
        new HorarioClase { nombreClase = "Automatización de sistemas-Sec.1 (08:00 - 10:00)", horaInicio = new TimeSpan(8, 0, 0), horaFin = new TimeSpan(10, 0, 0) },
        new HorarioClase { nombreClase = "Planificación y Control de Operaciones-Sec.2 (11:00 - 13:00)", horaInicio = new TimeSpan(11, 0, 0), horaFin = new TimeSpan(13, 0, 0) },
        new HorarioClase { nombreClase = "Mecanismos y Transmisión de Movimiento-Sec.1 (13:00 - 15:00)", horaInicio = new TimeSpan(13, 0, 0), horaFin = new TimeSpan(15, 0, 0) },
        new HorarioClase { nombreClase = "Sistemas Hidráulicos y Neumáticos-Sec.1 (15:00 - 17:00)", horaInicio = new TimeSpan(15, 0, 0), horaFin = new TimeSpan(17, 0, 0) },
        new HorarioClase { nombreClase = "Perú: Temas de la sociedad contemporánea-Sec.9 (17:00 - 19:00)", horaInicio = new TimeSpan(17, 0, 0), horaFin = new TimeSpan(19, 0, 0) },
        new HorarioClase { nombreClase = "RESERVADO (19:00 - 20:00)", horaInicio = new TimeSpan(19, 0, 0), horaFin = new TimeSpan(20, 0, 0) },
        new HorarioClase { nombreClase = "Gestión de Proyectos de Ingeniería-Sec.1 (20:00 - 22:00)", horaInicio = new TimeSpan(20, 0, 0), horaFin = new TimeSpan(22, 0, 0) }
    };

    public HorarioClase[] martesClases;
    public HorarioClase[] miercolesClases = new HorarioClase[]
    {
        new HorarioClase { nombreClase = "Mecanismos y Transmisión de Movimiento-Sec.1 (08:00 - 10:00)", horaInicio = new TimeSpan(8, 0, 0), horaFin = new TimeSpan(10, 0, 0) },
        new HorarioClase { nombreClase = "Mecánica de Materiales-Sec.3 (10:00 - 12:00)", horaInicio = new TimeSpan(10, 0, 0), horaFin = new TimeSpan(12, 0, 0) },
        new HorarioClase { nombreClase = "Historia de la Tecnología (12:00 - 13:00)", horaInicio = new TimeSpan(12, 0, 0), horaFin = new TimeSpan(13, 0, 0) },
        new HorarioClase { nombreClase = "RESERVADO (13:00 - 14:00)", horaInicio = new TimeSpan(13, 0, 0), horaFin = new TimeSpan(14, 0, 0) },
        new HorarioClase { nombreClase = "Química General-Sec.2 (14:00 - 16:00)", horaInicio = new TimeSpan(14, 0, 0), horaFin = new TimeSpan(16, 0, 0) },
        new HorarioClase { nombreClase = "Gestión de la Cadena de Suministros-Sec.2 (16:00 - 18:00)", horaInicio = new TimeSpan(16, 0, 0), horaFin = new TimeSpan(18, 0, 0) },
        new HorarioClase { nombreClase = "Sistemas de Información para Operaciones-Sec.1 (18:00 - 20:00)", horaInicio = new TimeSpan(18, 0, 0), horaFin = new TimeSpan(20, 0, 0) },
        new HorarioClase { nombreClase = "Sistemas de Información para Operaciones-Sec.2 (20:00 - 22:00)", horaInicio = new TimeSpan(20, 0, 0), horaFin = new TimeSpan(22, 0, 0) }
    };

    public HorarioClase[] juevesClases = new HorarioClase[]
    {
        new HorarioClase { nombreClase = "Dinámica-Sec.1 (08:00 - 10:00)", horaInicio = new TimeSpan(8, 0, 0), horaFin = new TimeSpan(10, 0, 0) },
        new HorarioClase { nombreClase = "Economía, Gobernanza y Relaciones de Poder-Sec.9 (10:00 - 12:00)", horaInicio = new TimeSpan(10, 0, 0), horaFin = new TimeSpan(12, 0, 0) },
        new HorarioClase { nombreClase = "Liderazgo y negociación-Sec.1 (12:00 - 14:00)", horaInicio = new TimeSpan(12, 0, 0), horaFin = new TimeSpan(14, 0, 0) },
        new HorarioClase { nombreClase = "Mecánica de Materiales-Sec.2 (14:00 - 16:00)", horaInicio = new TimeSpan(14, 0, 0), horaFin = new TimeSpan(16, 0, 0) },
        new HorarioClase { nombreClase = "Salud y Seguridad-Sec.1 (17:00 - 18:00)", horaInicio = new TimeSpan(17, 0, 0), horaFin = new TimeSpan(18, 0, 0) },
        new HorarioClase { nombreClase = "Análisis y Diseño de Sistemas-Sec.2 (18:00 - 20:00)", horaInicio = new TimeSpan(18, 0, 0), horaFin = new TimeSpan(20, 0, 0) },
        new HorarioClase { nombreClase = "Análisis y Diseño de Sistemas-Sec.1 (20:00 - 22:00)", horaInicio = new TimeSpan(20, 0, 0), horaFin = new TimeSpan(22, 0, 0) }
    };
    public HorarioClase[] viernesClases = new HorarioClase[]
    {
        new HorarioClase { nombreClase = "Fundamentos de Robótica-Sec.1 (08:00 - 09:00)", horaInicio = new TimeSpan(8, 0, 0), horaFin = new TimeSpan(9, 0, 0) },
        new HorarioClase { nombreClase = "Matemáticas Discretas II-Sec.2 (09:00 - 11:00)", horaInicio = new TimeSpan(9, 0, 0), horaFin = new TimeSpan(11, 0, 0) },
        new HorarioClase { nombreClase = "Sensores y Actuadores-Sec.1 (11:00 - 13:00)", horaInicio = new TimeSpan(11, 0, 0), horaFin = new TimeSpan(13, 0, 0) },
        new HorarioClase { nombreClase = "Investigación de Operaciones I: Modelos Probabilísticos-Sec (14:00 - 16:00)", horaInicio = new TimeSpan(14, 0, 0), horaFin = new TimeSpan(16, 0, 0) },
        new HorarioClase { nombreClase = "Investigación de Operaciones I: Modelos Probabilísticos-Sec (16:00 - 18:00)", horaInicio = new TimeSpan(16, 0, 0), horaFin = new TimeSpan(18, 0, 0) },
        new HorarioClase { nombreClase = "RESERVADO (18:00 - 20:00)", horaInicio = new TimeSpan(18, 0, 0), horaFin = new TimeSpan(20, 0, 0) }
    };

    public HorarioClase[] sabadoClases = new HorarioClase[]
    {
        new HorarioClase { nombreClase = "Mecánica de fluidos-Sec.1 (07:00 - 09:00)", horaInicio = new TimeSpan(7, 0, 0), horaFin = new TimeSpan(9, 0, 0) },
        new HorarioClase { nombreClase = "Análisis Estructural-Sec.1 (09:00 - 11:00)", horaInicio = new TimeSpan(9, 0, 0), horaFin = new TimeSpan(11, 0, 0) },
        new HorarioClase { nombreClase = "Máquinas Eléctricas-Sec.1 (11:00 - 13:00)", horaInicio = new TimeSpan(11, 0, 0), horaFin = new TimeSpan(13, 0, 0) }
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

        bool claseEncontrada = false;

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
