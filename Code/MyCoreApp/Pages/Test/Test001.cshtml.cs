using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyCoreApp.Pages.Test;

public class Test001Model : PageModel
{
    public void OnGet()
    {
    }
    public string TextBox { get; set; }
    public bool CheckBox { get; set; }
    public string RadioButton { get; set; }
    public string SelectBox { get; set; }
    public string TextArea { get; set; }
    public Test001Model()
    { 
        TextBox=""; 
        RadioButton="";
        SelectBox="";
        TextArea="";
    }

}
public enum RadioButton
{ 選択肢１,選択肢２,選択肢３ }
public enum SelectBox
{ 選択肢１,選択肢２,選択肢３ }
