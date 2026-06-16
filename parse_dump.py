import os
import re
import csv

dump_path = r"D:\Tinh\TheBonwater\Assets\_Project\Docs\BackendDecode\Il2CppDump\dump.cs"
out_dir = r"D:\Tinh\TheBonwater\Assets\_Project\Docs\BackendDecode"

keywords = [
    "Resource", "Inventory", "Item", "Building", "Build", "Construction", 
    "Villager", "Worker", "Profession", "Job", "Task", "Time", "Day", "Night", 
    "Food", "Hunger", "Health", "Combat", "Raid", "Enemy", "Save", "Load", 
    "GameManager", "Town", "Map", "Explore", "Expedition", "Weather", "Audio", 
    "FMOD", "IAP", "Ads", "Firebase"
]

def contains_keyword(text):
    text_lower = text.lower()
    for kw in keywords:
        if kw.lower() in text_lower:
            return kw
    return None

class_map = []
method_map = []
field_map = []
enum_map = []

# Regex patterns
class_pattern = re.compile(r'public (class|struct|interface) ([A-Za-z0-9_]+)')
enum_pattern = re.compile(r'public enum ([A-Za-z0-9_]+)')
field_pattern = re.compile(r'public ([A-Za-z0-9_<>,\[\]]+) ([A-Za-z0-9_]+);')
method_pattern = re.compile(r'public ([A-Za-z0-9_<>,\[\]]+) ([A-Za-z0-9_]+)\(')

with open(dump_path, 'r', encoding='utf-8') as f:
    lines = f.readlines()

current_class = None
current_type = None # "class", "enum"

for line in lines:
    line = line.strip()
    
    # Check for enum
    enum_match = enum_pattern.search(line)
    if enum_match:
        name = enum_match.group(1)
        kw = contains_keyword(name)
        if kw:
            enum_map.append({"source_symbol": name, "kind": "Enum", "source_file": "dump.cs", "probable_role": kw, "new_system": "", "new_class": "", "confidence": "HIGH", "evidence": "dump.cs", "note": ""})
        current_class = name
        current_type = "enum"
        continue
        
    # Check for class
    class_match = class_pattern.search(line)
    if class_match:
        name = class_match.group(2)
        kw = contains_keyword(name)
        if kw:
            class_map.append({"source_symbol": name, "kind": class_match.group(1).capitalize(), "source_file": "dump.cs", "probable_role": kw, "new_system": "", "new_class": "", "confidence": "HIGH", "evidence": "dump.cs", "note": ""})
        current_class = name
        current_type = "class"
        continue
        
    if current_class and current_type == "class":
        kw = contains_keyword(current_class)
        if not kw:
            continue
            
        field_match = field_pattern.search(line)
        if field_match:
            f_type = field_match.group(1)
            f_name = field_match.group(2)
            f_kw = contains_keyword(f_name)
            if f_kw:
                field_map.append({"source_symbol": f"{current_class}.{f_name}", "kind": "Field", "source_file": "dump.cs", "probable_role": f_kw, "new_system": "", "new_class": "", "confidence": "HIGH", "evidence": f"Type: {f_type}", "note": ""})
            continue
            
        method_match = method_pattern.search(line)
        if method_match:
            m_type = method_match.group(1)
            m_name = method_match.group(2)
            m_kw = contains_keyword(m_name)
            if m_kw:
                method_map.append({"source_symbol": f"{current_class}.{m_name}", "kind": "Method", "source_file": "dump.cs", "probable_role": m_kw, "new_system": "", "new_class": "", "confidence": "HIGH", "evidence": f"Returns: {m_type}", "note": ""})
            continue

def write_csv(filename, data):
    with open(os.path.join(out_dir, filename), 'w', newline='', encoding='utf-8') as f:
        writer = csv.DictWriter(f, fieldnames=["source_symbol", "kind", "source_file", "probable_role", "new_system", "new_class", "confidence", "evidence", "note"])
        writer.writeheader()
        writer.writerows(data)

os.makedirs(out_dir, exist_ok=True)
write_csv("OriginalBackendClassMap.csv", class_map)
write_csv("OriginalBackendMethodMap.csv", method_map)
write_csv("OriginalFieldMap.csv", field_map)
write_csv("OriginalEnumMap.csv", enum_map)

print(f"Parsed {len(class_map)} classes, {len(method_map)} methods, {len(field_map)} fields, {len(enum_map)} enums.")
