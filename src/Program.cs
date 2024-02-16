using System;
using System.Diagnostics;

namespace AptForWindows
{
    class Program
    {
        static void Main(string[] args)

        {

            // Check if any of the arguments contains "-?", "-h", or "--help"
            if (args.Length > 0 && (args[0] == "-?" || args[0] == "-h" || args[0] == "--help" || args[0] == "/help"))
            {
                DisplayCustomHelp();
                return;
            }

            // Handle custom arguments
            if (args.Length > 0)
            {
                switch (args[0])
                {
                    case "--setup":
                        Setup();
                        return;
                    case "-fix":
                        Fix();
                        return;
                    case "--install":
                        Install();
                        return;
                        // Add more custom argument cases as needed
                }
            }

            // Combine all other arguments into a single string
            string arguments = string.Join(" ", args);

            // Execute the WinGet command (equivalent to your original script)
            ExecuteWinGet(arguments);
        }

        static void ExecuteWinGet(string arguments)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "winget.exe",
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;
                    process.Start();

                    // Read the output (if needed)
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    // Print the output and error directly
                    Console.WriteLine(output);
                    Console.WriteLine(error);

                    process.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing WinGet: " + ex.Message);
            }
        }

        static void DisplayCustomHelp()
        {
            // Add your custom help message here
            Console.WriteLine("Apt For Windows Alpha-Preview (v0.1.0)");
            Console.WriteLine("Copyright (c) Daniel McGuire Corporation. All rights reserved.");
            Console.WriteLine();
            Console.WriteLine("Apt for Windows is an alias for winget (Windows Package Manager.)");
            Console.WriteLine();
            Console.WriteLine("usage: apt  [<command>] [<options>]");
            Console.WriteLine();
            Console.WriteLine("The following commands are available:");
            Console.WriteLine("  install    Installs the given package");
            Console.WriteLine("  show       Shows information about a package");
            Console.WriteLine("  source     Manage sources of packages");
            Console.WriteLine("  search     Find and show basic info of packages");
            Console.WriteLine("  list       Display installed packages");
            Console.WriteLine("  upgrade    Shows and performs available upgrades");
            Console.WriteLine("  uninstall  Uninstalls the given package");
            Console.WriteLine("  hash       Helper to hash installer files");
            Console.WriteLine("  validate   Validates a manifest file");
            Console.WriteLine("  settings   Open settings or set administrator settings");
            Console.WriteLine("  features   Shows the status of experimental features");
            Console.WriteLine("  export     Exports a list of the installed packages");
            Console.WriteLine("  import     Installs all the packages in a file");
            Console.WriteLine("  pin        Manage package pins");
            Console.WriteLine("  configure  Configures the system into a desired state");
            Console.WriteLine("  download   Downloads the installer from a given package");
            Console.WriteLine();
            Console.WriteLine("For more details on a specific command, pass it the help argument. [-?]");
            Console.WriteLine();
            Console.WriteLine("The following options are available:");
            Console.WriteLine("  -v,--version              Display the version of winget");
            Console.WriteLine("  --info                    Display general info of winget");
            Console.WriteLine("  -?,--help                 Shows help about the selected command");
            Console.WriteLine("  --wait                    Prompts the user to press any key before exiting");
            Console.WriteLine("  --logs,--open-logs        Open the default logs location");
            Console.WriteLine("  --verbose,--verbose-logs  Enables verbose logging for winget");
            Console.WriteLine("  --disable-interactivity   Disable interactive prompts");
            Console.WriteLine();
            Console.WriteLine("More help can be found at: https://placeholder.net/example1.jsp");
            Console.WriteLine("More help for WinGet can be found at: https://aka.ms/winget-command-help");
        }

        static void Setup()
        {
            // Custom install logic
            Console.WriteLine("Setting up Windows Package Manager");
            {
                try
                {
                    // strings:
                    string downloadUrl = "https://example.com/YourApp.msix";
                    string destinationPath = @"~\downloads";

                    // Download the MSIX package using Invoke-WebRequest
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = "powershell.exe",
                        Arguments = $"Invoke-WebRequest -Uri \"{downloadUrl}\" -OutFile \"{destinationPath}\"",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using (Process process = new Process())
                    {
                        process.StartInfo = startInfo;
                        process.Start();

                        // Read the output (if needed)
                        string output = process.StandardOutput.ReadToEnd();
                        string error = process.StandardError.ReadToEnd();

                        // Print the output and error directly
                        Console.WriteLine(output);
                        Console.WriteLine(error);

                        process.WaitForExit();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error downloading MSIX package: " + ex.Message);
                }
            }
        }

        static void Fix()
        {
            // Custom install logic
            Console.WriteLine("Attempting to fix by Installing Windows Package Manager");
            {
                try
                {
                    // strings:
                    string downloadUrl = "https://example.com/YourApp.msix";
                    string destinationPath = @"~\downloads";

                    // Download the MSIX package using Invoke-WebRequest
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = "powershell.exe",
                        Arguments = $"Invoke-WebRequest -Uri \"{downloadUrl}\" -OutFile \"{destinationPath}\"",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using (Process process = new Process())
                    {
                        process.StartInfo = startInfo;
                        process.Start();

                        // Read the output (if needed)
                        string output = process.StandardOutput.ReadToEnd();
                        string error = process.StandardError.ReadToEnd();

                        // Print the output and error directly
                        Console.WriteLine(output);
                        Console.WriteLine(error);

                        process.WaitForExit();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error downloading MSIX package: " + ex.Message);
                }
            }
        }

        static void Install()
        {
            // Custom install logic
            Console.WriteLine("Attempting to install Windows Package Manager");
            {
                try
                {
                    // strings:
                    string downloadUrl = "https://example.com/YourApp.msix";
                    string destinationPath = @"~\downloads";

                    // Download the MSIX package using Invoke-WebRequest
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = "powershell.exe",
                        Arguments = $"Invoke-WebRequest -Uri \"{downloadUrl}\" -OutFile \"{destinationPath}\"",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using (Process process = new Process())
                    {
                        process.StartInfo = startInfo;
                        process.Start();

                        // Read the output (if needed)
                        string output = process.StandardOutput.ReadToEnd();
                        string error = process.StandardError.ReadToEnd();

                        // Print the output and error directly
                        Console.WriteLine(output);
                        Console.WriteLine(error);

                        process.WaitForExit();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error downloading MSIX package: " + ex.Message);
                }
            }
        }
    }
}
