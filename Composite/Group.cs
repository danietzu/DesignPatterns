using System.Collections.Generic;

namespace Composite
{
    public class Group : IComponent
    {
        private readonly List<IComponent> _components = new List<IComponent>();

        public void Add(IComponent shape)
        {
            _components.Add(shape);
        }

        public void Render()
        {
            foreach (var component in _components)
                component.Render();
        }

        public void Move()
        {
            foreach (var component in _components)
                component.Move();
        }
    }
}