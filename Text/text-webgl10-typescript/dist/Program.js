"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var gl_matrix_1 = require("gl-matrix");
var Program = /** @class */ (function () {
    function Program() {
    }
    Program.Main = function () {
        // Just print identity matrix to the console
        var matrix = gl_matrix_1.mat4.create();
        console.log(matrix);
    };
    return Program;
}());
// Debug Version
// Program.Main();
// Release Version
window.onload = function () { return Program.Main(); };
