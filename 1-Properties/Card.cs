namespace Properties
{
    using System;

    /// <summary>
    /// The class models a card.
    /// </summary>
    public class Card
    {

        /*private readonly string _seed;
        private readonly string _name;
        private readonly int _ordinal;*/

        public Card(string seed, int ordinal) 
        {
            this.Seed = seed;
    this.Ordinal = ordinal;
   
        }
                public string Seed { get;}// auto - implemented readonly property
        public string Name { get;}
        public int Ordinal { get;}

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param _name="name">the name of the card.</param>
        /// <param _name="seed">the seed of the card.</param>
        /// <param _name="ordinal">the ordinal number of the card.</param>
        public Card(string name, string seed, int ordinal)
        {
            /*_name = name;
            _ordinal = ordinal;
            _seed = seed;*/
            Seed = seed;
            Name = name;
            Ordinal = ordinal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="tuple">the informations about the card as a tuple.</param>
        internal Card(Tuple<string, string, int> tuple) : this(tuple.Item1, tuple.Item2, tuple.Item3)
        {
        }

        // TODO improve
        /*public string GetSeed()
        {
            return _seed;
        }

        // TODO improve
        public string GetName()
        {
            return _name;
        }

        // TODO improve
        public int GetOrdinal()
        {
            return _ordinal;
        }*/

        /// <inheritdoc cref="object.ToString"/>
        /*public override string ToString()
        {
            // TODO understand string interpolation+
            return $"{this.GetType().Name}(Name={this.GetName()}, Seed={this.GetSeed()}, Ordinal={this.GetOrdinal()})";
        }*/
        public override string ToString() =>$"{this.GetType().Name}(Name={Name}, Seed={Seed}, Ordinal={Ordinal})";

        // TODO generate Equals(object obj)

        // TODO generate GetHashCode()
    }
}
