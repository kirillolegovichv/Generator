using RandGenerator;
using RandGenerator.API;

ApiClient apiClient = new ApiClient();
SequenceDisplay sd = new SequenceDisplay();

var sequence = sd.Start();
apiClient.AddSequence(sequence);


