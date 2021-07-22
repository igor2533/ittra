let m1=require("fs"),m2=require("crypto"),path="./tests",a;
m1.readdirSync(path).forEach(function(b){a=m1.readFileSync("tests/"+b);
a=m2.createHash("sha3-256").update(a).digest("hex");
console.log(b+" "+a)});