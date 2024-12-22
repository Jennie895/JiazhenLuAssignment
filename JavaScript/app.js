let salaries = {
  John: 100,
  Ann: 160,
  Pete: 130,
};
const sum = Object.values(salaries).reduce((acc, curr) => acc + curr, 0);
console.log(sum);

// =======2=====
function multiplyNumeric(obj) {
  for (let element in obj) {
    if (typeof obj[element] === "number") obj[element] *= 2;
  }
}
let menu = {
  width: 200,
  height: 300,
  title: "My menu",
};
multiplyNumeric(menu);
console.log(menu);

//======3======
function checkEmailId(str) {
  let atIndex = str.indexOf("@");
  let dotIndex = str.indexOf(".", atIndex);
  if (atIndex > -1 && dotIndex > atIndex + 1) return true;
  else return false;
}
console.log(checkEmailId("example@.com"));
console.log(checkEmailId("example@123.Com"));

//=========4=======
function truncate(str, maxlength) {
  if (str.length > maxlength) return str.slice(0, maxlength - 1) + "...";
  else return str;
}

console.log(truncate("What I'd like to tell on this topic is:", 20));
console.log(truncate("Hi everyone!", 20));

//============5========
let array = ["James", "Brennie"];
console.log(array);

array.push("Robert");
console.log(array);

const middlepoint = Math.floor(array.length / 2);
array[middlepoint] = "Calvin";
console.log(array);

array.shift();
console.log(array);

array.unshift("Rose", "Regal");
console.log(array);
