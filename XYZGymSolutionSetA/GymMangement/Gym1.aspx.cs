using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GymMangement.ServiceReference2;
namespace GymMangement
{
    public partial class Gym1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RangeValidator1.MaximumValue = DateTime.Now.ToLongDateString();
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client();
            GymMember gym = new GymMember();
            gym.MemberCode = TextBox1.Text;
            gym.MemberName = TextBox2.Text;
            gym.EmailId = TextBox3.Text;
            gym.PhoneNumber = Convert.ToInt64(TextBox4.Text);
            gym.MemberShipStartDate = Convert.ToDateTime(TextBox5.Text);
            gym.MemberShipDuration = DropDownList1.SelectedItem.Text;
            int added = client.CreateMember(gym);
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString(), "alert('added successfully')", true);
        }
    }
}