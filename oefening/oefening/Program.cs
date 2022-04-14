using System;

namespace oefening
{
    class Student
    {
        public override string ToString()
        {
            return base.ToString();
        }
    }

    internal abstract class Skill
    {
        internal string name;

        internal abstract void Use();

        internal virtual void OnActivate()
        {

        }
    }



    internal class FireBall : Skill
    {
        internal override void Use()
        {
            throw new NotImplementedException();
        }
    }
}
