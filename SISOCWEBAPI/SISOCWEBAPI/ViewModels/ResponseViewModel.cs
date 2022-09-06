namespace SISOCWEBAPI.ViewModels
{
	public class ResponseViewModel
	{
		public string AccessToken { get; set; }
		public double ExpiresIn { get; set; }
		public UsuarioViewModel UserToken { get; set; }
	}
}
