using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace ClinicalTrail.GeneralObjectStore.Logger
{
    /// <summary>
    /// implementation for NLog
    /// </summary>
    public class NLogLogger : ILogger
    {
        private NLog.Logger _logger;

        /// <summary>
        /// initialize a logger object
        /// </summary>
        /// <param name="name">the name</param>
        public void Initialize(string name)
        {
            _logger = LogManager.GetLogger(name);
        }
        /// <summary>
        /// log message with trace level
        /// </summary>
        /// <param name="message">message to log</param>
        public void Trace(string message)
        {
            if (_logger != null)
                _logger.Trace(message);
        }
        /// <summary>
        /// log message with trace level
        /// </summary>
        /// <param name="message">message to log</param>
        /// <param name="ex">exception to log</param>
        public void Trace(string message, Exception ex)
        {
            if (_logger != null)
                _logger.TraceException(message, ex);
        }
        /// <summary>
        /// log message with debug level
        /// </summary>
        /// <param name="message">message to log</param>
        public void Debug(string message)
        {
            if (_logger != null)
                _logger.Debug(message);
        }
        /// <summary>
        /// log message with debug level
        /// </summary>
        /// <param name="message">message to log</param>
        /// <param name="ex">exception to log</param>
        public void Debug(string message, Exception ex)
        {
            if (_logger != null)
                _logger.DebugException(message, ex);
        }
        /// <summary>
        /// log message with info level
        /// </summary>
        /// <param name="message">message to log</param>
        public void Info(string message)
        {
            if (_logger != null)
                _logger.Info(message);
        }
        /// <summary>
        /// log message with info level
        /// </summary>
        /// <param name="message">message to log</param>
        /// <param name="ex">exception to log</param>
        public void Info(string message, Exception ex)
        {
            if (_logger != null)
                _logger.InfoException(message, ex);
        }
        /// <summary>
        /// log message with warn level
        /// </summary>
        /// <param name="message">message to log</param>
        public void Warn(string message)
        {
            if (_logger != null)
                _logger.Warn(message);
        }
        /// <summary>
        /// log message with warn level
        /// </summary>
        /// <param name="message">message to log</param>
        /// <param name="ex">exception to log</param>
        public void Warn(string message, Exception ex)
        {
            if (_logger != null)
                _logger.WarnException(message, ex);
        }
        /// <summary>
        /// log message with error level
        /// </summary>
        /// <param name="message">message to log</param>
        public void Error(string message)
        {
            if (_logger != null)
                _logger.Error(message);
        }
        /// <summary>
        /// log message with error level
        /// </summary>
        /// <param name="message">message to log</param>
        /// <param name="ex">exception to log</param>
        public void Error(string message, Exception ex)
        {
            if (_logger != null)
                _logger.ErrorException(message, ex);
        }
        /// <summary>
        /// log message with fatal level
        /// </summary>
        /// <param name="message">message to log</param>
        public void Fatal(string message)
        {
            if (_logger != null)
                _logger.Fatal(message);
        }
        /// <summary>
        /// log message with fatal level
        /// </summary>
        /// <param name="message">message to log</param>
        /// <param name="ex">exception to log</param>
        public void Fatal(string message, Exception ex)
        {
            if (_logger != null)
                _logger.FatalException(message, ex);
        }
    }
}
