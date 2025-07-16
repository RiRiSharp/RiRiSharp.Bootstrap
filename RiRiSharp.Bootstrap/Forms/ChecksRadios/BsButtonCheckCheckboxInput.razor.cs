namespace RiRiSharp.Bootstrap.Forms.ChecksRadios;

public partial class BsButtonCheckCheckboxInput : BsInputBase<bool>
{
    protected override bool TryParseValueFromString(string value, out bool result, out string validationErrorMessage)
    {
        throw new NotImplementedException("This method is not necessary for parsing input checkboxes.");
    }

    protected override string DetermineClasses()
    {
        return "btn-check";
    }
}