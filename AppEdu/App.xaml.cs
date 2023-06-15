﻿using AppEdu.Models;
using AppEdu.Pages;
using AppEdu.Services.AlumnosService;
using AppEdu.Services.CalendarioService;
using AppEdu.Services.DirectorService;
using AppEdu.Services.Docente_GrupoService;
using AppEdu.Services.DocenteMateriaService;
using AppEdu.Services.DocenteService;
using AppEdu.Services.GrupoService;
using AppEdu.Services.MateriaService;
using AppEdu.Services.NotasService;

namespace AppEdu;

public partial class App : Application
{

    public static DirectorInfo DirectorInfo;
    public static DirectorService _directorService;

	public static DocenteInfo DocenteInfo;
	public static DocenteService _docenteService;

	public static Docente_Grupo DocenteGrupo;
	public static Docente_GrupoService _docenteGrupoService;

    public static GruposInfo GrupoInfo;
    public static GrupoService _grupoService;

    public static MateriasInfo MateriasInfo;
    public static MateriaService _materiaService;

    public static DocenteMateria DocenteMateria;
    public static DocenteMateriaService _docenteMateriaService;

    public static NotasInfo NotasInfo;
    public static NotasService _notasService;

    public static AlumnosInfo AlumnosInfo;
    public static AlumnoService _alumnoService;

    public static CalendarioInfo CalendarioInfo;
    public static CalendarioService _CalendarioService;


    public static DirectorService DirectorService
    {
        get
        {
            if(_directorService == null)
            {
                _directorService = new DirectorService();
            }
            return _directorService;
        }
    }

    public static DocenteService DocenteService
	{
		get
		{
			if(_docenteService == null)
			{
				_docenteService = new DocenteService();
			}
			return _docenteService;
		}
	}

    public static Docente_GrupoService Docente_GrupoService
    {
        get
        {
            if (_docenteGrupoService == null)
            {
                _docenteGrupoService = new Docente_GrupoService();
            }
            return _docenteGrupoService;
        }
    }

    public static GrupoService GrupoService
    {
        get
        {
            if (_grupoService == null)
            {
                _grupoService = new GrupoService();
            }
            return _grupoService;
        }
    }

    public static MateriaService MateriaService
    {
        get
        {
            if (_materiaService == null)
            {
                _materiaService = new MateriaService();
            }
            return _materiaService;
        }
    }

    public static DocenteMateriaService DocenteMateriaService
    {
        get
        {
            if (_docenteMateriaService == null)
            {
                _docenteMateriaService = new DocenteMateriaService();
            }
            return _docenteMateriaService;
        }
    }

    public static NotasService NotasService
    {
        get
        {
            if(_notasService == null)
            {
                _notasService = new NotasService();
            }
            return _notasService;
        }
    }

    public static AlumnoService AlumnoService
    {
        get
        {
            if (_alumnoService == null)
            {
                _alumnoService = new AlumnoService();
            }
            return _alumnoService;
        }
    }

    public static CalendarioService CalendarioService
    {
        get
        {
            if (_CalendarioService == null)
            {
                _CalendarioService = new CalendarioService();
            }
            return _CalendarioService;
        }
    }

    public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new LoginPage());
	}
}
