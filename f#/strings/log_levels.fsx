// Introductory exercise
// Strings practice 
// Usage of different string methods (Substring, indexOf, Trim, ToLower)

module LogLevels

// Implement the message function to return a log line's message
let message (logLine: string): string = 
    if logLine[1] = 'W' then
        let logMessage = logLine.Substring(10) 
        logMessage.Trim()
    elif logLine[1] = 'I' then 
        let logMessage = logLine.Substring(7) 
        logMessage.Trim() 
    else
        let logMessage = logLine.Substring(8) 
        logMessage.Trim()  

message "[WARNING]: Disk almost full\r\n" // "Disk almost full"
message "[INFO]: Info operation" // "Info operation"
message "[ERROR]: Invalid operation" // "Invalid operation"

// Implement the logLevel function to return a log line's log level, which should be returned in lowercase
let logLevel(logLine: string): string = 
    let start = logLine.IndexOf('[') 
    let ending = logLine.IndexOf(']') 
    logLine.Substring(start+1,ending-1).ToLower()

logLevel "[ERROR]: Invalid operation" // "error"
logLevel "[WARNING]: Disk almost full\r\n" // "warning"
logLevel "[INFO]: Info operation" // "info"

// Implement the reformat function that reformats the log line, putting the message first and the log level after it in parentheses
let reformat(logLine: string): string =
    let logMessage = message logLine
    let logLevel = logLevel logLine
    logMessage + " (" + logLevel + ")"


reformat "[INFO]: Operation completed" // "Operation completed (info)"
