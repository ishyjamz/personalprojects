const express = require("express");
const app = express();
const bodyParser = require("body-parser");

app.use(bodyParser.json());
app.use("/", express.static(__dirname + "/"));

app.post("/save-task", function (req, res) {
  const obj = req.body;
  console.log("saved task: ", obj.task);
  res.send({ savedTask: obj.task });
});

app.get("/get-tasks", function (req, res) {
  const tasks = ["Eat less", "Don't be fat", "Be a man"];
  res.send({ tasks: tasks });
});

function start() {
  console.log("app running");
}

app.listen(3000, start());
