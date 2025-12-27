process.stdin.resume();
process.stdin.setEncoding("ascii");
var inputData = "";

process.stdin.on("data", function (chunk) {
  inputData += chunk;
});

process.stdin.on("end", function () {
  const output = writeOutput(inputData);
  console.log(output);
});

function writeOutput(inputData) {
  return inputData;
}
