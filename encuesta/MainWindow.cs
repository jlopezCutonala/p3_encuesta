using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	protected void OnCombobox1Changed (object sender, EventArgs e)
	{
	}	

	protected void OnBtnGuardarClicked (object sender, EventArgs e)
	{
		string estado = this.cmbEstado.ActiveText;

		string lenguajes = "";
		if(this.chkIslandes.Active){
			lenguajes = "Islandes,";
		}
		
		if(this.chkIngles.Active){
			lenguajes += "Inglés,";
		}
		
		if(this.chkAleman.Active){
			lenguajes += "Aleman";
		}

		string sexo = "";
		if(this.radMasculino.Active){
			sexo = "Masculino";
		}else if(this.radFemenino.Active){
			sexo = "Femenino";
		}

		string edad = this.spinEdad.Text;
		string comentario = this.txtComentarios.Buffer.Text;
		DateTime fecha = this.calFecha.GetDate();

		MessageDialog md = new MessageDialog (null, 
      	DialogFlags.Modal,
  		MessageType.Info, 
      	ButtonsType.None, "Estos son los datos: \n" +
                           "Estado: " + estado +"\n"+
                           "Lenguajes: " + lenguajes +"\n"+
                           "Sexo: " + sexo +"\n"+
                           "Edad: " + edad +"\n"+
                           "Observaciones: " + comentario +"\n" +
		                   "Fecha: " + fecha.ToShortDateString() +"\n"
        );
		md.Show();
	}	
	protected void OnCalFechaPrevMonth (object sender, EventArgs e)
	{
		MessageDialog md = new MessageDialog (null, 
      	DialogFlags.Modal,
  		MessageType.Info, 
      	ButtonsType.None, "Mes anterior"
        );
		md.Show();
	}	
	protected void OnCalFechaNextMonth (object sender, EventArgs e)
	{
		MessageDialog md = new MessageDialog (null, 
      	DialogFlags.Modal,
  		MessageType.Info, 
      	ButtonsType.None, "Mes siguiente"
        );
		md.Show();
	}

	protected void OnShown (object sender, EventArgs e)
	{
		MessageDialog md = new MessageDialog (null, 
      	DialogFlags.Modal,
  		MessageType.Info, 
      	ButtonsType.None, "Bienvenido"
        );
		md.Show();
	}


	protected void OnCalFechaDaySelected (object sender, EventArgs e)
	{
		Calendar calendario = (Calendar)sender;
		DateTime fecha = calendario.GetDate();
		MessageDialog md = new MessageDialog (null, 
      	DialogFlags.Modal,
  		MessageType.Info, 
      	ButtonsType.None, "Fecha: " + fecha.ToShortDateString() +"\n"
        );
		md.Show();
	}





}
