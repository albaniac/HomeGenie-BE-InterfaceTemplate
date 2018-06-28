using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualStudio.TemplateWizard;
using EnvDTE;

namespace HomeGenie_BE_InterfaceWizard
{
    public class WizardImplementation : IWizard
    {
        private UserInputForm inputForm;
        private string domain;
        private string author;
        private string projectHomePage;
        private string description;

        public static Dictionary<string, string> GlobalDictionary = new Dictionary<string, string>();

        // This method is called before opening any item that   
        // has the OpenInEditor attribute.  
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        // This method is only called for item templates,  
        // not for project templates.  
        public void ProjectItemFinishedGenerating(ProjectItem
            projectItem)
        {
        }

        // This method is called after the project is created.  
        public void RunFinished()
        {
        }

        public void RunStarted(object automationObject,
            Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind, object[] customParams)
        {
            try
            {
                GlobalDictionary["$saferootprojectname$"] = replacementsDictionary["$safeprojectname$"];

                // Display a form to the user. The form collects   
                // input for the custom message.  
                inputForm = new UserInputForm();
                inputForm.ShowDialog();

                domain = UserInputForm.Domain;
                author = UserInputForm.Author;
                projectHomePage = UserInputForm.ProjectHomePage;

                // Add custom parameters.  
                replacementsDictionary.Add("$domain$", domain);
                replacementsDictionary.Add("$author$", author);
                replacementsDictionary.Add("$projecthomepage$", projectHomePage);
                replacementsDictionary.Add("$description$", description);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // This method is only called for item templates,  
        // not for project templates.  
        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}