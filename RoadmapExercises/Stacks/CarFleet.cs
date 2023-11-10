namespace RoadmapExercises.Stacks
{
    //https://leetcode.com/problems/car-fleet/
    public static class CarFleet
    {
        public static int Logic1(int target, int[] position, int[] speed)
        {
            var carList = position.Select((pos, index) => (pos, time: (double)(target - pos)/ speed[index]))
                .OrderByDescending(x => x.pos)
                .ToList();

            double finishTime = 0;
            var carFleets = 0;
            foreach ( var car in carList) {
                if (car.time > finishTime)
                { 
                    finishTime = car.time;
                    carFleets++;
                }
            }
            return carFleets;
        }

        public static int Logic2(int target, int[] position, int[] speed)
        {
            var carList = position.Select((pos, index) => (pos, time: (double)(target - pos) / speed[index]))
                .OrderByDescending(x => x.pos)
                .ToList();

            var stack = new Stack<double>();
            foreach (var car in carList)
            {
                if (stack.Count != 0 && stack.Peek() >= car.time)
                    continue;

                stack.Push(car.time);
            }
            return stack.Count;
        }
    }
}