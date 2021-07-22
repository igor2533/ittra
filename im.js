let path="C:/ittra/stest",m1=require("fs"),m2=require("crypto"),a;
m1.readdirSync(path).forEach(function(b){a=m1.readFileSync("stest/"+b);
a=m2.createHash("sha3-256").update(a).digest("hex");
console.log(b+" "+a)});