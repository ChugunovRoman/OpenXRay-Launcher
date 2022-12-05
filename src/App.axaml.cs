// using System.Runtime.InteropServices;
// using System.Security.Principal;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace Launcher;

public partial class App : Application
{
  public override void Initialize()
  {
    // RequireAdministrator();

    AvaloniaXamlLoader.Load(this);
  }

  public override void OnFrameworkInitializationCompleted()
  {
    if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
    {
      desktop.MainWindow = new MainWindow();
    }

    base.OnFrameworkInitializationCompleted();
  }

  // public static void RequireAdministrator()
  // {
  //   string name = System.AppDomain.CurrentDomain.FriendlyName;
  //   try
  //   {
  //     if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
  //     {
  //       using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
  //       {
  //         WindowsPrincipal principal = new WindowsPrincipal(identity);
  //         if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
  //         {
  //           throw new InvalidComObjectException($"Application must be run as administrator. Right click the {name} file and select 'run as administrator'.");
  //         }
  //       }
  //     }
  //     else if (getuid() != 0)
  //     {
  //       throw new InvalidComObjectException($"Application must be run as root/sudo. From terminal, run the executable as 'sudo {name}'");
  //     }
  //   }
  //   catch (Exception ex)
  //   {
  //     throw new ApplicationException("Unable to determine administrator or root status", ex);
  //   }
  // }
}