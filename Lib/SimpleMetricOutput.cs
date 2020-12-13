namespace SystemTextJsonEncodingReference.Lib
{
    public class SimpleMetricOutput
    {
        public SimpleMetricOutput(double doubleMetric)
        {
            Instance = string.Empty;
            Name = string.Empty;
            Value = doubleMetric;
        }

        public SimpleMetricOutput()
        {
        }

        public string Entity { get; set; }
        public string Instance { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
    }
}


