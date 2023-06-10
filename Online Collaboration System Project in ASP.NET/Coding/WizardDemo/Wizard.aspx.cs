using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace WizardDemo
{
	/// <summary>
	/// 
	/// Demo application for article titled "Panels can do Wonders" 
	/// Published at ASPAlliance.Com
	/// Author: - By Rajiv. R, Rajspace.Org.
	/// 
	///NOTE:  "WizardPosition" is attribute added to Button btnNext to track the position of the wizard.
	///
	/// 
	/// </summary>
	public class WizardPage : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Panel pnlStep2;
		protected System.Web.UI.WebControls.Panel pnlStep3;
		protected System.Web.UI.WebControls.Panel pnlStep4;
		protected System.Web.UI.WebControls.Button btnNext;
		protected System.Web.UI.WebControls.Button btnBack;
		protected System.Web.UI.WebControls.Button btnCancel;
		protected System.Web.UI.WebControls.Panel pnlStep1;
		protected System.Web.UI.WebControls.Literal ltAuthor;

	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			if(!this.IsPostBack)
				btnNext.Attributes.Add("WizardPosition","1");			//Setting "WizardPosition" to "1" , i.e wizard is in Step 1
		}


		private void btnNext_Click(object sender, System.EventArgs e)
		{
			manageWizard('N');		//Calling manageWizard() with argument "N" to denote "NEXT" was clicked
		}

		private void btnBack_Click(object sender, System.EventArgs e)
		{
			manageWizard('B');	//Calling manageWizard() with argument "B" to denote "BACK" was clicked
		}


		private void manageWizard(char operation)
		{
			int lintWizardStep=Convert.ToInt32(btnNext.Attributes["WizardPosition"]);

			if(operation=='N')
			{
				if(lintWizardStep==1)		//If TRUE, wizard was in Step 1 and NEXT has been clicked 
				{
					pnlStep1.Visible=false;
					pnlStep2.Visible =true;			//Wizard in Step 2
					btnNext.Attributes.Add("WizardPosition","2");		

					btnBack.Enabled =true;			//Enabling "BACK" button for Step 2
				}
				else if(lintWizardStep==2)		//If TRUE, wizard was in Step 2 and NEXT has been clicked 
				{
					pnlStep2.Visible=false;
					pnlStep3.Visible =true;			//Wizard in Step 3
					btnNext.Attributes.Add("WizardPosition","3");

					btnNext.Text ="Save";			//In last step (Step3), Changing button text of btnNEXT to SAVE from NEXT 
				}
				else if(lintWizardStep==3)		//If TRUE, wizard was in Step 3 and NEXT has been clicked 
				{
					processWizard();
					Response.Redirect ("WizardComplete.aspx");
				}

			}
			else if (operation=='B')
			{
				if(lintWizardStep==3)	//If TRUE, wizard was in Step 3 and BACK has been clicked 
				{
					pnlStep3.Visible=false;
					pnlStep2.Visible =true;			//Wizard in Step 2
					btnNext.Attributes.Add("WizardPosition","2");

					btnNext.Text ="Next";	//Changing button text of btnNEXT to NEXT from SAVE
				}
				else if(lintWizardStep==2)		//If TRUE, wizard was in Step 2 and BACK has been clicked 
				{
					pnlStep2.Visible=false;
					pnlStep1.Visible =true;			//Wizard in Step 1
					btnNext.Attributes.Add("WizardPosition","1");

					btnBack.Enabled =false;
				}
				else if(lintWizardStep==1)			//If TRUE, wizard was in Step 1 and BACK has been clicked 
				{
					//Code to Handle "Back" click in Step1
				}

			}
		}

		private void processWizard()
		{
			//Wizard Processing Code Here !
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			Response.Redirect ("WizardCancelled.aspx");		
		}
	}
}
