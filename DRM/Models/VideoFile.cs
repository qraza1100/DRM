﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class VideoFile
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required, MaxLength(255)]
    public string Name { get; set; }

    [Required]
    public byte[] EncryptedContent { get; set; } // Securely Encrypted Video Data

    [MaxLength(100)]
    public string Category { get; set; }

    public TimeSpan? Length { get; set; } // Nullable duration

    public DateTime DateOfUpload { get; set; } = DateTime.UtcNow;

    public bool Lock { get; set; } = false; // Default to false

    [Required, MaxLength(128)]
    public string UploadedBy { get; set; } // Security tracking for uploader
}
