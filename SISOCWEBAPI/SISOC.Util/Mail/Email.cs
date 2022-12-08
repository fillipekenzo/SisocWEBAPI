using System.Net;
using RazorLight;
using System.Text;
using System.Net.Mail;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Configuration;
using System.Net.Mime;

namespace SISOC.Util.Mail
{
	public class Email
	{
		private readonly IConfiguration _configuration;
		public string Host;
		public int Porta;
		public string EmailDoSistema;
		public string Senha;
		public bool UtilizarSsl;
		public bool UtilizarCredenciasPadroes;

		public Email(IConfiguration config)
		{
			_configuration = config;
			Host = _configuration["Email:Smtphost"].ToString();
			Porta = Int32.Parse(_configuration["Email:SmtpPorta"]);
			EmailDoSistema = _configuration["Email:EmailDoSistema"].ToString();
			Senha = _configuration["Email:SenhaDoEmailDoSistema"].ToString();
			UtilizarSsl = Boolean.Parse(_configuration["Email:UtilizarSsl"]);
			UtilizarCredenciasPadroes = Boolean.Parse(_configuration["Email:UtilizarCredenciasPadroes"]);
		}

		public void Enviar(List<string> destinatarios, List<string>? copiasDestinatarios, List<string>? copiasDestinatariosOcultos, string assunto, string corpoHTML, string anexo = "")
		{
			try
			{
				MailMessage objEmail = new MailMessage();
				objEmail.From = new MailAddress(EmailDoSistema);

				//adiciona os destinatarios
				foreach (string destinatario in destinatarios)
				{
					objEmail.To.Add(destinatario);
				}

				//adiciona as copias dos destinatarios
				foreach (string copiaDestinatario in copiasDestinatarios)
				{
					objEmail.CC.Add(copiaDestinatario);
				}

				//adiciona as copias ocultas dos destinatarios
				foreach (string copiasDestinatariosOculto in copiasDestinatariosOcultos)
				{
					objEmail.Bcc.Add(copiasDestinatariosOculto);
				}

				//prioridade do email
				objEmail.Priority = MailPriority.High;

				//utilize true pra ativar html no conteúdo do email, ou false, para somente texto
				objEmail.IsBodyHtml = true;
				objEmail.Subject = assunto;
				objEmail.Body = corpoHTML;
				//objEmail.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(corpo, new ContentType("text/plain")));
				objEmail.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(corpoHTML, new ContentType("text/html")));

				//codificação do corpo do emailpara que os caracteres acentuados serem reconhecidos.
				objEmail.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");

				if (!string.IsNullOrEmpty(anexo))
				{
					var bytes = Convert.FromBase64String(anexo);
					Stream stream = new MemoryStream(bytes);
					Attachment attachment = new Attachment(stream, "arquivo.xlsx");
					objEmail.Attachments.Add(attachment);
				}

				SmtpClient objSmtp = new SmtpClient(Host, Porta);
				objSmtp.Credentials = new NetworkCredential(EmailDoSistema, Senha);
				objSmtp.UseDefaultCredentials = UtilizarCredenciasPadroes;
				objSmtp.EnableSsl = UtilizarSsl;

				objSmtp.Send(objEmail);
			}
			catch (SmtpException ex)
			{
				throw new Exception("Não foi possível o envio do e-mail. Motivo: " + ex.Message);
			}
		}


		//public string GerarTemplate(string caminhoTemplate)
		//{

		//	var exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
		//	Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
		//	var appRoot = appPathMatcher.Match(exePath).Value;
		//	string urlTemplate = Path.Combine(appRoot + "./Views/EmailTemplate/template", caminhoTemplate);
		//	string template = File.ReadAllText(urlTemplate, Encoding.Default);
		//	return template;
		//}

		//public async Task<String> RunCompile<T>(string template, T model)
		//{
		//	var engine = new RazorLightEngineBuilder()
		//		.UseEmbeddedResourcesProject(typeof(Email))
		//		.UseMemoryCachingProvider()
		//		.SetOperatingAssembly(typeof(Email).Assembly)
		//		.Build();


		//	return await engine.CompileRenderStringAsync("SISOC", template, model);
		//}

		//public LinkedResource CarregarLogoIFMS()
		//{

		//	string baseDirectory = AppDomain.CurrentDomain.BaseDirectory.ToString();
		//	Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
		//	var appRoot = appPathMatcher.Match(baseDirectory).Value;
		//	string url = Path.Combine(appRoot + "./Views/EmailTemplate/images/ifms.png");
		//	LinkedResource inlineLogo = new LinkedResource(url, "image/png");
		//	inlineLogo.ContentId = Guid.NewGuid().ToString();
		//	return inlineLogo;
		//}

	}
}
