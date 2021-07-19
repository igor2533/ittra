function lcs(strings){let z1=strings.reduce((y,z)=>y.length<=z.length?y:z);let z2=z1.length;for(let z3=z2;z3>=0;z3--)
{for(let z4=0;z4<=z2-z3;z4++){let z5 = z1.substring(z4, z4+z3);if(strings.every(elem=>~elem.indexOf(z5))){
return z5;}}}return '';}if(process.argv.length<3){}else{console.log(lcs(process.argv.slice(2)));}
