using Lab1;

namespace Lab1Tests
{
    public class Tests
    {

        [Test]
        public void ShouldReturnAtLeastOneItemWhenItMeetsContrains()
        {
            List<Item> items =new List<Item>() { new Item(0,1,4), new Item(1,20,10),new Item(2,40,2)};
            Problem problem = new Problem(items);
            Result result = problem.Solve(10);
            Assert.That(result.Items.Count, Is.AtLeast(1));
        }
        [Test]
        public void ShouldReturnEmptyListWhenNoneOfItemsMeetsConstrains()
        {
            List<Item> items = new List<Item>() { new Item(0, 500, 4), new Item(1, 20, 10), new Item(2, 40, 2) };
            Problem problem = new Problem(items);
            Result result = problem.Solve(10);
            Assert.That(result.Items, Is.Empty);
        }
        [Test]
        public void ShouldReturnSameResultForTheListsOfItemsWithDiffrentOrder()
        {
            Problem problem = new Problem(2, 10);
            Result result1 = problem.Solve(10);
            problem.Items=problem.Items.OrderBy(x=>x.Value).ToList();
            Result result2 = problem.Solve(10);
            Assert.That(result1.Items,Is.EqualTo(result2.Items));
        }
        [Test]
        public void ShouldReturnExpectedResult()
        {
            List<Item> items = new List<Item>() {
                new Item(0,4,7),
                new Item(1,22,14),
                new Item(2,13, 19),
                new Item(3,27, 10),
                new Item(4,18,3),
                new Item(5,7,1),
                new Item(6,28,9),
                new Item(7,19,20),
                new Item(8,18,8),
                new Item(9,20,20),
            };
            Result expectedResult = new Result(new List<Item>() {
                new Item(0,4,7),
                new Item(2,13,19),
                new Item(7,19,20),
                new Item(5,7,1) });
            Problem problem = new Problem(items);
            Result result = problem.Solve(50);
            Assert.That(result.ToString(),Is.EqualTo(expectedResult.ToString()));
        }
        [Test]
        public void ShouldReturnSubsetOfInitialItemsAsResult()
        {
            Problem problem = new Problem(5, 10);
            Result result = problem.Solve(50);
            Console.Write(result.ToString());
            Assert.That((problem.Items.Intersect(result.Items).ToList()), Is.EqualTo(result.Items.OrderBy(x=>x.Id)));
        }
        [Test]
        public void ShouldReturnListWithSameSizeWhenEveryItemsInListsMeetContrains()
        {
            Problem problem=new Problem(5, 10);
            Result result=problem.Solve(10000);
            Assert.That(result.Items.Count, Is.EqualTo(problem.Items.Count));
        }
        [Test]
        public void ShouldReturnListOrderDesendingByValueWeightRatio()
        {
            Problem problem = new Problem(5, 10);
            Result result = problem.Solve(10000);
            Assert.That(result.Items, Is.EqualTo(problem.Items.OrderByDescending(x => (double)(x.Value) / (double)(x.Weight))));
        }
        [Test]
        public void ShouldReturnResultsWhenTotalWeightIsLessEqualThanCapacity()
        {
            Problem problem = new Problem(7, 10);
            int capacity = 30;
            Result result = problem.Solve(capacity);
            int totalWeight = result.Items.Sum(x=> x.Weight);
            Assert.That(totalWeight, Is.LessThanOrEqualTo(capacity));
        }
    }
}