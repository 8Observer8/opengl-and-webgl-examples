import { mat4 } from "gl-matrix";

class Program
{
    public static Main(): void
    {
        // Just print identity matrix to the console
        let matrix = mat4.create();
        console.log(matrix);
    }
}

// Debug Version
// Program.Main();

// Release Version
window.onload = () => Program.Main();
