﻿namespace DirScan.Service
{
    public class DirectoryDataSummary
    {
        public int FileCount { get; set; }
        public int DirectoryCount { get; set; }
        public long Size { get; set; }
        public string TotalSize
        {
            get
            {
                if (Size > 1024000000000)
                    return $"{(double)Size / 1024000000000,5:0.#} TB";
                if (Size > 1024000000)
                    return $"{(double)Size / 1024000000,5:0.#} GB";
                else if (Size > 1024000)
                    return $"{(double)Size / 1024000,5:0.#} MB";
                else if (Size > 1024)
                    return $"{(double)Size / 1024,5:0.#} KB";

                return $"{Size,5} Bytes";
            }

        }
    }
}