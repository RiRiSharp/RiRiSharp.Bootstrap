namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

public partial class BsLabelButton : BsChildContentComponent
{
    private const string Button = "btn";
    private readonly string _buttonLabelClasses;

    public BsLabelButton(string additionalButtonLabelClasses = "")
    {
        if (string.IsNullOrWhiteSpace(additionalButtonLabelClasses)) return;
        _buttonLabelClasses = $"{Button} {additionalButtonLabelClasses}";
    }
}

public class BsLabelButtonPrimary() : BsLabelButton("btn-primary");
public class BsLabelButtonSecondary() : BsLabelButton("btn-secondary");
public class BsLabelButtonSuccess() : BsLabelButton("btn-success");
public class BsLabelButtonDanger() : BsLabelButton("btn-danger");
public class BsLabelButtonInfo() : BsLabelButton("btn-info");
public class BsLabelButtonLight() : BsLabelButton("btn-light");
public class BsLabelButtonDark() : BsLabelButton("btn-dark");
public class BsLabelButtonLink() : BsLabelButton("btn-link");

public class BsLabelButtonOutlinePrimary() : BsLabelButton("btn-outline-primary");
public class BsLabelButtonOutlineSecondary() : BsLabelButton("btn-outline-secondary");
public class BsLabelButtonOutlineSuccess() : BsLabelButton("btn-outline-success");
public class BsLabelButtonOutlineDanger() : BsLabelButton("btn-outline-danger");
public class BsLabelButtonOutlineInfo() : BsLabelButton("btn-outline-info");
public class BsLabelButtonOutlineLight() : BsLabelButton("btn-outline-light");
public class BsLabelButtonOutlineDark() : BsLabelButton("btn-outline-dark");