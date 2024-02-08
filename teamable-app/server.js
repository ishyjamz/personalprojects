const express = require("express");
const app = express();
const bodyParser = require("body-parser");

app.use(bodyParser.json());
app.use("/", express.static(__dirname + "/dist"));

app.get("/get-profile", function (req, res) {
  const response = {
    name: "Josh",
    email: "josh@gmail.com",
    interests: "netflix",
  };
  res.send(response);
});

app.post("/update-user-profile", function (req, res) {
  const obj = req.body;
  console.log(obj);
  if (Object.keys(obj).length === 0) {
    res.status(400).send({ error: "empty payload" });
  } else {
    res.send({ info: "user profile data updated successfully" });
  }
});

function start() {
  console.log("app started");
}

app.listen(3000, start());
