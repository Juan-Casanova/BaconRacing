using System.Collections;
using System.Collections.Generic;

public class MovimientoPropsEngine
{
    public float _rotation;

    public float rotationObject()
    {

        if (_rotation > 1.0f)
        {
            _rotation -= 0.05f;
        }
        else if (_rotation < -1.0f || _rotation <= 0)
        {
            _rotation += 0.05f;
        }

        return _rotation;
    }

}
