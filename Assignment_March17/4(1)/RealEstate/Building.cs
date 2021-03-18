namespace RealEstate
{
    class Building
    {
        public int area, occupants, floors;

        public Building(int area, int occupants, int floors)
        {
            this.area = area;
            this.occupants = occupants;
            this.floors = floors;
        }

        public int printArea()
        {
            return this.area;
        }

        public int CalculateAreaPerPerson()
        {
            return this.area / this.occupants;
        }
    }
}