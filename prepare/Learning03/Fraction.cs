public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction (int topWholeNumber)
    {
        _topNumber = topWholeNumber;
        _bottomNumber = 1;
    }

    public Fraction (int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    public int get_topNumber()
    {
        return this._topNumber;
    }

    public void set_topNumber(int _topNumber)
    {
        this._topNumber = _topNumber;
    }

    public int get_bottomNumber()
    {
        return this._bottomNumber;
    }

    public void set_bottomNumber(int _bottomNumber)
    {
        this._bottomNumber = _bottomNumber;
    }

    public string getFractionString()
    {
        string fractionString = $"{_topNumber}/{_bottomNumber}";
        return fractionString;
    }

    public double getDecimalValue()
    {
        return (double)_topNumber/(double)_bottomNumber;
    }


}