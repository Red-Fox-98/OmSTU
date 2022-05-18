using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Character
    {
        Transform transform;
        Collider collider;
        Avatar avatar;
        Body body;

        public Character(int x, int y, Avatar avatar, List<Collider> colliders)
        {
            transform = new Transform(x, y);
            this.avatar = avatar;
            this.body = new Body(transform, new Vector(0, 0), 5);
            collider = new Collider(transform, colliders, 1.5f);
        }

        public void Move(int x_, int y_)
        {
            body.AddVelocity(new Vector(x_, y_));
        }

        public void Update()
        {
            if (collider.CollisionCheck())
            {
                transform.position.x = 0;
                transform.position.y = 0;
            }
            body.Update();
            avatar.Draw((int)transform.position.x, (int)transform.position.y);
        }
    }
}