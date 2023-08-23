using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_pattern.@object
{
    public abstract class Vehicle
    {
        private String _make;
        private String _model;
        private String _bodyColor;
        private String _engine;
        private List<String> _parts;

        // Constructors

        public Vehicle(String make, String model, String bodyColor, String engine, List<String> parts)
        {
            _make = make;
            _model = model;
            _bodyColor = bodyColor;
            _engine = engine;
            _parts = parts;
        }

        public Vehicle()
        {
            _make = "default";
            _model = "default";
            _bodyColor = "default";
            _engine = "default";
            _parts = new List<String>();
        }

        // Accessors

        public String Make
        {
            get { return _make; }
            set
            {
                _make = value;
            }
        }

        public String Model
        {
            get { return _model; }
            set
            {
                _model = value;
            }
        }

        public String BodyColor
        {
            get { return _bodyColor; }
            set
            {
                _bodyColor = value;
            }
        }

        public String Engine
        {
            get { return _engine; }
            set
            {
                _engine = value;
            }
        }

        public List<String> Parts
        {
            get { return _parts; }
            set
            {
                _parts = value;
            }
        }

        // Methods

        public override bool Equals(object? obj)
        {
            return (obj as Vehicle)._make == _make && (obj as Vehicle)._model == _model && (obj as Vehicle)._engine == _engine && (obj as Vehicle)._bodyColor == _bodyColor && (obj as Vehicle)._parts == _parts;
        }

        public void Add(String part)
        {
            _parts.Add(part);
        }

        public void ShowObject()
        {
            Console.WriteLine(this);
        }
    }
}
