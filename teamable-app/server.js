const express = require("express");
const app = express();
const bodyParser = require("body-parser");
const { MongoClient } = require("mongodb");

const url = "mongodb://localhost:27017";
const client = new MongoClient(url);
const dbName = "compan_db";
const colName = "employees";

app.use(bodyParser.json());
app.use("/", express.static(__dirname + "/dist"));

app.get("/get-profile", async function (req, res) {
  // connect to mongodb database
  await client.connect();
  console.log("Connected successfully to server");

  // initiate or get the db & collection
  const db = client.db(dbName);
  const collection = db.collection(collName);

  // get data from database
  const result = await collection.findOne({ id: 1 });
  console.log(result);
  client.close();

  response = {};
  if (result !== null) {
    response = {
      name: result.name,
      email: result.email,
      interests: result.interests,
    };
  }
  res.send(response);
});

app.post("/update-user-profile", async function (req, res) {
  const obj = req.body;
  console.log(obj);

  if (Object.keys(obj).length === 0) {
    res.status(400).send({ error: "empty payload" });
  } else {
    //make connection
    await client.connect();
    console.log("connection to db success");

    //initiate db
    const db = client.db(dbName);
    const collection = db.collection(colName);

    //save payload data to db
    payload["id"] = 1;
    await collection.insertOne(payload);

    res.send({ info: "user data updatation success" });
  }
});

function start() {
  console.log("app started");
}

app.listen(3000, start());
